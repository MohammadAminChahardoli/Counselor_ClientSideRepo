using CounselorClient.ApiConnections;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using CounselorClient.Models;
using static CounselorClient.Classes.NetworkConnection;

namespace CounselorClient.Forms
{
    public partial class ConsultationRecipientForm : Form , IApiResponseObserver
    {
        private List<Chat> Chats;
        private List<Models.Message> Messages;
        private Timer FormUpdateTimer;
        private const int FormUpdateInterval = 5000;


        public ConsultationRecipientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Messages = new List<Models.Message>();
            GetChats();
            InitializeTimer();
        }

        private void GetChats()
        {
            if (IsNetworkAvailable())
            {
                RecipentChatDownloader chatsDownloader = new RecipentChatDownloader();
                chatsDownloader.Attach(this);
                chatsDownloader.GetChats(Program.UserId);
                labelWating.Visible = true;
            }
            else
            {
                MessageBox.Show("کاربر گرامی دستگاه شما به اینترنت متصل نیست");
            }
        }

        private void GetMessages(int chatId)
        {
            MessageDownloader messageDownloader = new MessageDownloader();
            messageDownloader.Attach(this);
            messageDownloader.GetMessages(chatId);
            labelWating.Visible = true;
        }

        private void ReloadMessages(int chatId)
        {
            MessageDownloader messageDownloader = new MessageDownloader();
            messageDownloader.Attach(this);
            messageDownloader.GetMessages(chatId);
        }

        private void SendNewMessage(int userIdReceiver, int chatId)
        {
            NewChatModel newChat = new NewChatModel();
            newChat.ChatId = chatId;
            newChat.ChatMessageText = textBoxMessage.Text;
            newChat.UserIdReciver = userIdReceiver;
            newChat.UserIdSender = Program.UserId;
            newChat.UserIdStarter = userIdReceiver;

            ChatUploader chatUploader = new ChatUploader();
            chatUploader.Attach(this);
            chatUploader.InsertNewMessage(newChat);
            labelWating.Visible = true;
        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            labelWating.Visible = false;

            if (requestCode == RequestCodes.ChatsReceived)
            {
                Chats = (List<Chat>)response;
                listBoxChats.Items.Clear();
                for (int i = 0; i < Chats.Count; i++)
                {
                    listBoxChats.Items.Add("گفتگوی شماره " + (i + 1));
                }
                listBoxChats.SelectedIndex = listBoxChats.Items.Count - 1;
            }
            else if (requestCode == RequestCodes.MessagesReceived)
            {
                List<Models.Message> messages = (List<Models.Message>)response;
                if (messages.Count > Messages.Count)
                {
                    Messages = messages;
                    if (Messages.Count != 0)
                    {
                        listBoxMessages.Items.Clear();
                        foreach (var message in Messages)
                        {
                            if (int.Parse(message.UserIdSender) == Program.UserId)
                            {
                                listBoxMessages.Items.Add("شما: " + message.ChatMessageText);
                            }
                            else
                            {
                                listBoxMessages.Items.Add("مشاور: " + message.ChatMessageText);
                            }
                        }
                        listBoxMessages.TopIndex = listBoxMessages.Items.Count - 1;
                    }
                }
            }
            else if (requestCode == RequestCodes.NewMessageSent)
            {
                GetChats();
                labelSending.Visible = false;
                buttonSendMessage.Enabled = true;
            }
        }

        private void listBoxChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messages.Clear();
            int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
            GetMessages(selectedChatId);
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            int chatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
            int receiverId = int.Parse(Chats[listBoxChats.SelectedIndex].UserIdStarter);
            SendNewMessage(receiverId, chatId);
            textBoxMessage.Text = string.Empty;
            labelSending.Visible = true;
            buttonSendMessage.Enabled = false;
        }

        private void InitializeTimer()
        {
            FormUpdateTimer = new Timer();
            FormUpdateTimer.Interval = FormUpdateInterval;
            FormUpdateTimer.Tick += FormUpdateTimer_Tick;
            FormUpdateTimer.Start();
        }

        private void FormUpdateTimer_Tick(object sender, EventArgs e)
        {
            if(listBoxChats.SelectedIndex != -1)
            {
                int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                ReloadMessages(selectedChatId);
            }
        }

        private void ConsultationRecipientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUpdateTimer.Enabled = false;
            FormUpdateTimer.Dispose();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void ConsultationRecipientForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetChats();
        }
    }
}
