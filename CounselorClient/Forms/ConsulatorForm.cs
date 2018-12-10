using CounselorClient.ApiConnections;
using CounselorClient.Models;
using System;
using System.Collections.Generic;
using System.Threading;
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
        private List<QuizValidateModel> QuizList;
        private List<ExtractedProperAnswer> extractProperAnswer;
        private System.Timers.Timer FormUpdateTimer;
        private const int FormUpdateInterval = 5000;
        private int CurrentRecipentUserId = 0;
        private Random RandomInstance;
        private bool IsFirstMessage = true;


        public ConsulatorForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Messages = new List<Models.Message>();
            Answers = new List<string>();
            RobotWellcomeTexts = new string[] { "سلام", "سلام وقت شما بخیر", "سلام حالتون خوبه. ممنونم که وقت میذارید. من آماده ام", "سلام به شما", "سلام و عرض ادب", "وقت بخیر", "سلام حال شما خوبه. بفرمایید سوالات رو بپرسید." };
            QuizList = new List<QuizValidateModel>();
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
            usersDownloader.GetUsers(Program.UserId);
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
            //string messageText = Questions[0].QuestionTitle;
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

            RobotMessageUploader chatUploader = new RobotMessageUploader();
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

        private void ValidateProperAnswer(Models.Message userMessage)
        {
            if (QuizList.Count != 0)
            {
                ProperAnswerValidator properAnswerValidator = new ProperAnswerValidator();
                properAnswerValidator.Attach(this);
                properAnswerValidator.ValidateProperAnswer(new ProperAnswerModel
                {
                    AnswerText = userMessage.ChatMessageText,
                    QuestionId = QuizList[QuizList.Count - 1].QuestionId,
                });
                labelWating.Visible = true;
            }

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
                listBoxChats.TopIndex = listBoxChats.Items.Count - 1;
            }
            else if (requestCode == RequestCodes.MessagesReceived)
            {
                List<Models.Message> messages = (List<Models.Message>)response;
                if (messages.Count > Messages.Count)
                {
                    Messages = messages;
                    try
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
                                listBoxMessages.Items.Add("کاربر: " + message.ChatMessageText);
                            }
                        }
                        listBoxMessages.TopIndex = listBoxMessages.Items.Count - 1;

                        for (int i = Messages.Count - 1; i >= 0; --i)
                        {
                            if (int.Parse(Messages[i].UserIdSender) != Program.UserId)
                            {
                                ValidateProperAnswer(Messages[i]);
                                break;
                            }
                        }
                    }
                    catch {; }
                }
            }
            else if (requestCode == RequestCodes.NewMessageSent)
            {
                //Add current question(the question that just has been asked.) to the quiz list.
                if (listBoxQuestions.SelectedIndex != -1)
                {
                    QuizList.Add(new QuizValidateModel
                    {
                        QuestionId = int.Parse(Questions[listBoxQuestions.SelectedIndex].QuestionId),
                        QuestionKey = Questions[listBoxQuestions.SelectedIndex].QuestionKey
                    });
                }

                GetChats();
                labelSending.Visible = false;
                buttonSendMessage.Enabled = true;

                //If is Robot, then the robot response to judge.
                if (IsFirstMessage && Users[listBoxUsers.SelectedIndex].RoleId == (int)RoleTypes.RobotRole)
                {
                    int randomNumber = RandomInstance.Next(0, RobotWellcomeTexts.Length - 1);
                    int randomDelay = RandomInstance.Next(7000, 15000);
                    Thread.Sleep(randomDelay);
                    SendMessageFromRobot(int.Parse(Chats[listBoxChats.SelectedIndex].ChatId), int.Parse(Users[listBoxUsers.SelectedIndex].UserId), RobotWellcomeTexts[randomNumber]);
                    IsFirstMessage = false;
                }
            }
            else if (requestCode == RequestCodes.AnswersReceived)
            {
                if (Users[listBoxUsers.SelectedIndex].RoleId == (int)RoleTypes.RobotRole)
                {
                    if (Messages.Count == 1)
                    {
                        int randomNumber = RandomInstance.Next(0, RobotWellcomeTexts.Length - 1);
                        int randomDelay = RandomInstance.Next(1000, 2000);
                        Thread.Sleep(randomDelay);
                        SendMessageFromRobot(int.Parse(Chats[listBoxChats.SelectedIndex].ChatId), int.Parse(Users[listBoxUsers.SelectedIndex].UserId), RobotWellcomeTexts[randomNumber]);
                    }
                    else
                    {
                        Answers = (List<string>)response;
                        int randomNumber = RandomInstance.Next(0, Answers.Count - 1);
                        int randomDelay = RandomInstance.Next(1000, 2000);
                        Thread.Sleep(randomDelay);
                        SendMessageFromRobot(int.Parse(Chats[listBoxChats.SelectedIndex].ChatId), int.Parse(Users[listBoxUsers.SelectedIndex].UserId), Answers[randomNumber]);
                    }
                }
            }
            else if (requestCode == RequestCodes.NewMessageSentFromRobot)
            {
                GetChats();
            }
            else if (requestCode == RequestCodes.ProperAnswerValidator)
            {
                if (listBoxQuestions.SelectedIndex != -1)
                {
                    extractProperAnswer = new List<ExtractedProperAnswer>();
                    extractProperAnswer = (List<ExtractedProperAnswer>)response;
                    for (int i = 0; i < QuizList.Count; ++i)
                    {
                        if (QuizList[i].QuestionId == int.Parse(Questions[listBoxQuestions.SelectedIndex].QuestionId))
                        {
                            if (extractProperAnswer.Count > 0)
                            {
                                QuizList[i].AnswerKeySection = int.Parse(extractProperAnswer[0].AnswerKeyCode);
                                QuizList[i].QuestiontypeId = int.Parse(extractProperAnswer[0].QuestionTypeId);
                            }
                            else
                            {
                                QuizList[i].AnswerKeySection = 2;
                                QuizList[i].QuestiontypeId = 3;
                            }
                            break;
                        }
                    }
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
            QuizList.Clear();
            InsertNewChat(int.Parse(Users[listBoxUsers.SelectedIndex].UserId));
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                int selectedUserId = int.Parse(Users[listBoxUsers.SelectedIndex].UserId);
                SendNewMessage(selectedUserId, selectedChatId);
                labelSending.Visible = true;
                buttonSendMessage.Enabled = false;
                GetAnswers(int.Parse(Questions[listBoxQuestions.SelectedIndex].QuestionId));
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
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void InitializeTimer()
        {
            FormUpdateTimer = new System.Timers.Timer();
            FormUpdateTimer.Interval = FormUpdateInterval;
            FormUpdateTimer.Elapsed += FormUpdateTimer_Elapsed;
            FormUpdateTimer.Start();
        }

        private void FormUpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (listBoxChats.SelectedIndex != -1)
            {
                int selectedChatId = int.Parse(Chats[listBoxChats.SelectedIndex].ChatId);
                ReloadMessages(selectedChatId);
            }
        }

        private void buttonEndChat_Click(object sender, EventArgs e)
        {
            FinishChat();
        }

        private void FinishChat()
        {
          
        }

        private void GetPerosnalityType()
        {
            QuizValidator quizValidator = new QuizValidator();
           string extractedPersonality = quizValidator.DeterminPerosnalityKey(QuizList);
            if(extractedPersonality.Length>=4)
            {
                this.Invoke(new Action(() =>
                {
                    this.Hide();
                    UserPersonalityForm personalityForm = new UserPersonalityForm(QuizList);
                    personalityForm.Show();

                }));
            }
            else
            {
                MessageBox.Show("هنوز مجاز به انجام این عمل نیستید");

            }
            //------------------------------------------------------------
           


        }
    }
}
