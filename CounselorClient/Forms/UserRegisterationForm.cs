using CounselorClient.ApiConnections;
using CounselorClient.Models;
using System;
using System.Windows.Forms;
using static CounselorClient.Classes.NetworkConnection;

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
            if (IsNetworkAvailable())
            {
                UserSignUp.SignUp(newUser);
            }
            else
            {
                MessageBox.Show("کاربر گرامی دستگاه به اینترنت متصل نیست");
            }
        }

        private User GetUserModel()
        {
            User newUser = new User
            {
                RoleId = comboBoxRoleType.SelectedIndex == 1 ? 1 : 3,
                FirstName = textBoxName.Text,
                LastName = textBoxFamily.Text,
                Age = textBoxAge.Text != string.Empty ? int.Parse(textBoxAge.Text) : 0,
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

        private void GetRoleType(int userId)
        {
            UserRoleType userRoleType = new UserRoleType();
            userRoleType.Attach(this);
            userRoleType.GetUserRoleId(userId);
        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            if (requestCode == RequestCodes.UserSignedUp)
            {
                int result = int.Parse(response.ToString());
                if (result > 0)
                {
                    Program.UserId = int.Parse(response.ToString());
                    GetRoleType(userId: int.Parse(response.ToString()));
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
            else if (requestCode == RequestCodes.RoleTypeReceived)
            {
                labelWating.Visible = false;

                int result = int.Parse(response.ToString());
                if (result == (int)RoleTypes.CounseltorRole)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                        ConsulatorForm consulatorForm = new ConsulatorForm();
                        consulatorForm.Show();
                    }));
                }
                else if (result == (int)RoleTypes.CounselorRecipentRole || result == (int)RoleTypes.RobotRole)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                        ConsultationRecipientForm recipientForm = new ConsultationRecipientForm();
                        recipientForm.Show();
                    }));
                }
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
