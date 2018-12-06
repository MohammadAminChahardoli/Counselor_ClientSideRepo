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
    public partial class UserRegisterationForm : Form, IApiResponseObserver
    {
        private UserSignUp UserSignUp;
        public UserRegisterationForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ConsultationRecipientForm recipientForm = new ConsultationRecipientForm();
            //recipientForm.Show();

            UserSignUp = new UserSignUp();
            UserSignUp.Attach(this);
            SignUp(GetUserModel());
        }

        private void SignUp(User newUser)
        {
            labelWating.Visible = true;
            UserSignUp.SignUp(newUser);
        }

        private User GetUserModel()
        {
            return new User
            {
                RoleId = 1,
                FirstName = "MohamadAmin",
                LastName = "Chahardoli",
                Age = 22,
                Majore = "Software Engiring",
                UserName = "MAC139709",
                Password = "654321"
            };
        }

        public void OnResponse<T>(T response)
        {
            int result = int.Parse(response.ToString());
            labelWating.Visible = false;
            if (result > 0)
            {
                MessageBox.Show("Successful.");
            }
            else if (result == 0)
            {
                MessageBox.Show("You are already signed up.");
            }
            else if (result == -1)
            {
                MessageBox.Show("Somthing bad happend.");
            }
            else
            {
                MessageBox.Show("Nothing.");
            }
        }
    }
}
