using CounselorClient.ApiConnections;
using CounselorClient.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CounselorClient.Classes.NetworkConnection;

namespace CounselorClient.Forms
{
    public partial class ConsulatorForm : Form, IApiResponseObserver
    {
        private List<Chat> Chats;
        private List<User> Users;
        private List<Question> Questions;
        List<Models.Message> Messages;
        private List<string> Answers;
        private string[] RobotWellcomeTexts;
        private Timer FormUpdateTimer;
        private const int FormUpdateInterval = 5000;
        private int CurrentRecipentUserId = 0;
        private Random RandomInstance;
        private bool IsFirstMessage = false;


        public ConsulatorForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Messages = new List<Models.Message>();
            Answers = new List<string>();
            RobotWellcomeTexts = new string[] { "سلام", "سلام وقت شما بخیر", "سلام حالتون خوبه. ممنونم که وقت میذارید. من آماده ام", "سلام به شما", "سلام و عرض ادب", "وقت بخیر", "سلام حال شما خوبه. بفرمایید سوالات رو بپرسید." };
            RandomInstance = new Random();
            InitializeContextMenu();
            GetQuestions();
            InitializeTimer();
        }

        private void GetQuestions()
        {
            labelWating.Visible = true;
            if (IsNetworkAvailable())
            {
                QuestionsDownloader questionsDownloader = new QuestionsDownloader();
                questionsDownloader.Attach(this);
                questionsDownloader.GetQuestions();
            }
            else
            {
                MessageBox.Show("کاربر گرامی دستگاه شما به اینترنت متصل نیست");
            }
        }

        private void GetUsers()
        {
            UsersDownloader usersDownloader = new UsersDownloader();
            usersDownloader.Attach(this);
            usersDownloader.GetUsers();
            labelWating.Visible = true;
        }

        private void GetChats()
        {
            ChatDownloader chatsDownloader = new ChatDownloader();
            chatsDownloader.Attach(this);
            chatsDownloader.GetChats(Program.UserId);
            labelWating.Visible = true;
        }

        private void GetMessages(int chatId)
        {
            MessageDownloader messageDownloader = new MessageDownloader();
            messageDownloader.Attach(this);
            messageDownloader.GetMessages(chatId);
            labelWating.Visible = true;
        }

        private void InsertNewChat(int userIdReceiver)
        {
            NewChatModel newChat = new NewChatModel();
            newChat.ChatId = 0;
            string messageText = "سلام، وقت بخیر... بنده مشاور شغلی شما هستم. بیایید درمورد شغل آینده شما صحبت کنیم لطفا به سوالاتی که میپرسم با دقت پاسخ دهید..";
            newChat.ChatMessageText = messageText;
            newChat.UserIdReciver = userIdReceiver;
            newChat.UserIdSender = Program.UserId;
            newChat.UserIdStarter = Program.UserId;

            ChatUploader chatUploader = new ChatUploader();
            chatUploader.Attach(this);
            chatUploader.InsertNewMessage(newChat);
            labelWating.Visible = true;
            IsFirstMessage = true;
        }

        private void SendNewMessage(int userIdReceiver, int chatId)
        {
            NewChatModel newChat = new NewChatModel();
            newChat.ChatId = chatId;
            string messageText = Questions[listBoxQuestions.SelectedIndex].QuestionTitle;
            newChat.ChatMessageText = messageText;
            newChat.UserIdReciver = userIdReceiver;
            newChat.UserIdSender = Program.UserId;
            newChat.UserIdStarter = Program.UserId;

            CurrentRecipentUserId = userIdReceiver;
            ChatUploader chatUploader = new ChatUploader();
            chatUploader.Attach(this);
            chatUploader.InsertNewMessage(newChat);
            labelWating.Visible = true;
            IsFirstMessage = false;
        }

        private void SendMessageFromRobot(int chatId, int senderId, string message)
        {
            NewChatModel newChat = new NewChatModel();
            newChat.ChatId = chatId;
            newChat.ChatMessageText = message;
            newChat.UserIdReciver = Program.UserId;
            newChat.UserIdSender = senderId;
            newChat.UserIdStarter = senderId;

            ChatUploader chatUploader = new ChatUploader();
            chatUploader.Attach(this);
            chatUploader.InsertNewMessage(newChat);
        }

        private void ReloadMessages(int chatId)
        {
            MessageDownloader messageDownloader = new MessageDownloader();
            messageDownloader.Attach(this);
            messageDownloader.GetMessages(chatId);
        }

        private void GetAnswers(int questionId)
        {
            AnswersDownloader answersDownloader = new AnswersDownloader();
            answersDownloader.Attach(this);
            answersDownloader.GetAnswers(questionId);
        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            labelWating.Visible = false;

            if (requestCode == RequestCodes.QuestionDownloaded)
            {
                Questions = (List<Question>)response;
                foreach (var question in Questions)
                {
                    listBoxQuestions.Items.Add(question.QuestionId + "- " + question.QuestionTitle);
                }
                GetUsers();
            }
            else if (requestCode == RequestCodes.UsersDownloaded)
            {
                Users = (List<User>)response;
                foreach (var user in Users)
                {
                    listBoxUsers.Items.Add(user.FirstName + " " + user.LastName);
                }
                GetChats();
            }
            else if (requestCode == RequestCodes.ChatsReceived)
            {
                Chats = (List<Chat>)response;
                listBoxChats.Items.Clear();
                for (int i = 0; i < Chats.Count; i++)
                {
                    listBoxChats.Items.Add("گفتگوی شماره " + (i + 1));
                }
                listBoxChats.SelectedIndex = listBoxChats.Items.Count - 1;
                
                if (IsFirstMessage)
                {
                    if (Users[listBoxUsers.SelectedIndex].RoleId == (int)RoleTypes.RobotRole)
                    {
                        int questionId = int.Parse(Questions[listBoxQuestions.SelectedIndex].QuestionId);
                        GetAnswers(questionId);
                    }
                }
                else if(!IsFirstMessage)
                {
                    int randomNumber = RandomInstance.Next(0, RobotWellcomeTexts.Length - 1);
                    try
                    {
                        int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                        int selectedUserId = int.Parse(Users[listBoxUsers.SelectedIndex].UserId);
                        SendMessageFromRobot(selectedChatId, selectedUserId, RobotWellcomeTexts[randomNumber]);
                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده است.");
                    }
                }
            }
            else if (requestCode == RequestCodes.MessagesReceived)
            {
                List<Models.Message> messages = (List<Models.Message>)response;
                if (messages.Count > Messages.Count)
                {
                    Messages = messages;
                    listBoxMessages.Items.Clear();
                    foreach (var message in Messages)
                    {
                        if (int.Parse(message.UserIdSender) == Program.UserId)
                        {
                            listBoxMessages.Items.Add("شما: " + message.ChatMessageText);
                        }
                        else
                        {
                            listBoxMessages.Items.Add("کاربر: " + message.ChatMessageText);
                        }
                    }
                    listBoxMessages.TopIndex = listBoxMessages.Items.Count - 1;
                }
            }
            else if (requestCode == RequestCodes.NewMessageSent)
            {
                GetChats();
            }
            else if (requestCode == RequestCodes.AnswersReceived)
            {
                Answers = (List<string>)response;
                int randomNumber = RandomInstance.Next(0, Answers.Count - 1);
                try
                {
                    int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                    int selectedUserId = int.Parse(Users[listBoxUsers.SelectedIndex].UserId);
                    SendMessageFromRobot(selectedChatId, selectedUserId, Answers[randomNumber]);
                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده است.");
                }
            }
        }

        private void listBoxChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messages.Clear();
            int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
            GetMessages(selectedChatId);
        }

        private void InitializeContextMenu()
        {
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("گفتگوی جدید با کاربر");
            contextMenu.MenuItems[0].Click += ConsulatorForm_Click;
            listBoxUsers.ContextMenu = contextMenu;
        }

        private void ConsulatorForm_Click(object sender, EventArgs e)
        {
            InsertNewChat(int.Parse(Users[listBoxUsers.SelectedIndex].UserId));
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                int selectedUserId = int.Parse(Users[listBoxUsers.SelectedIndex].UserId);
                SendNewMessage(selectedUserId, selectedChatId);
            }
            catch
            {
                MessageBox.Show("لطفا قبل از ارسال پیام ، کاربر گیرنده و چت مورد نظر را وارد نمایید.");
            }
            
        }

        private void ConsulatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUpdateTimer.Enabled = false;
            FormUpdateTimer.Dispose();
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
    }
}
