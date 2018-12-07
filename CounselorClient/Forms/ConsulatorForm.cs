using CounselorClient.ApiConnections;
using CounselorClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounselorClient.Forms
{
    public partial class ConsulatorForm : Form , IApiResponseObserver
    {
        public ConsulatorForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            GetQuestions();
        }


        private void GetQuestions()
        {
            QuestionsDownloader questionsDownloader = new QuestionsDownloader();
            questionsDownloader.Attach(this);
            questionsDownloader.GetQuestions();
            labelWating.Visible = true;
        }

        private void GetUsers()
        {
            UsersDownloader usersDownloader = new UsersDownloader();
            usersDownloader.Attach(this);
            usersDownloader.GetUsers();
            labelWating.Visible = true;
        }

        private void ConsulatorForm_Load(object sender, EventArgs e)
        {

        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            labelWating.Visible = false;

            if (requestCode == RequestCodes.QuestionDownloaded)
            {
                List<Question> questions = (List<Question>)response;
                foreach (var question in questions)
                {
                    listBoxQuestions.Items.Add(question.QuestionId + "- " + question.QuestionTitle);
                }
                GetUsers();
            }
            else if(requestCode == RequestCodes.UsersDownloaded)
            {
                List<User> users = (List<User>)response;
                foreach (var user in users)
                {
                    listBoxUsers.Items.Add(user.FirstName + " " + user.LastName);
                }
            }
        }
    }
}
