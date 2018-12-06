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
            comboBoxRoleType.SelectedIndex = 0;
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            UserSignUp = new UserSignUp();
            UserSignUp.Attach(this);
            if (ValidateUserInfo(GetUserModel()))
                SignUp(GetUserModel());
            else
                MessageBox.Show("لطفا همه مقادیر را وارد نمایید");
        }

        private void SignUp(User newUser)
        {
            labelWating.Visible = true;
            UserSignUp.SignUp(newUser);
        }

        private User GetUserModel()
        {
            User newUser = new User
            {
                RoleId = comboBoxRoleType.SelectedIndex,
                FirstName = textBoxName.Text,
                LastName = textBoxFamily.Text,
                Age = textBoxAge.Text != string.Empty? int.Parse(textBoxAge.Text) : 0,
                Majore = textBoxMajore.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text
            };

            return newUser;
        }

        private bool ValidateUserInfo(User user)
        {
            return
                (user.FirstName != string.Empty &&
                user.LastName != string.Empty &&
                user.Age > 0 &&
                user.Majore != string.Empty &&
                user.UserName != string.Empty &&
                user.Password != string.Empty &&
                user.RoleId != 0);
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
            else if (result == (int)SignUpStatus.AlreadyRegistered)
            {
                MessageBox.Show("شما قبلا ثبت نام کرده اید");
            }
            else if (result == (int)SignUpStatus.Exception)
            {
                MessageBox.Show("خطایی رخ داده");
            }
        }

        private void UserRegisterationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
