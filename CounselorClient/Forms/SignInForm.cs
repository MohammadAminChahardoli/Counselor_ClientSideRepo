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
    public partial class SignInForm : Form, IApiResponseObserver
    {
        private UserSingIn UserSignIn;
        public SignInForm()
        {
            InitializeComponent();

        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserRegisterationForm signUpForm = new UserRegisterationForm();
            signUpForm.Show();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            UserSignIn = new UserSingIn();
            UserSignIn.Attach(this);
            SignIn(GetUserInfo());
        }

        private void SignIn(SignInModel info)
        {
            labelWating.Visible = true;
            if (ValidatUserInfo(info))
                UserSignIn.SignIn(info);
            else
                MessageBox.Show("لطفا همه مقادیر را به درستی واردی نمایید");
        }

        public void OnResponse<T>(T response)
        {
            int result = int.Parse(response.ToString());
            labelWating.Visible = false;
            if (result > 0)
            {
                this.Invoke(new Action(() =>
                {
                    this.Hide();
                    ConsultationRecipientForm recipientForm = new ConsultationRecipientForm();
                    recipientForm.Show();
                }));
            }
            else if (result == (int)LoginStatus.WrongPasswordOrUserName)
            {
                MessageBox.Show("نام کاربری یا گذرواژه اشتباه است");
            }
        }

        private SignInModel GetUserInfo()
        {
            return new SignInModel
            {
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text
            };
        }

        private bool ValidatUserInfo(SignInModel userInfo)
        {
            return
                (textBoxUserName.Text != string.Empty &&
                textBoxPassword.Text != string.Empty);
        }
    }
}
