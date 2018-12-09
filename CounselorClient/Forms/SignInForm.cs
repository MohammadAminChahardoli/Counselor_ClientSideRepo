using CounselorClient.ApiConnections;
using CounselorClient.Models;
using System;
using System.Windows.Forms;
using static CounselorClient.Classes.NetworkConnection;

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
            if(IsNetworkAvailable())
            {
                if (ValidatUserInfo(info))
                    UserSignIn.SignIn(info);
                else
                    MessageBox.Show("لطفا همه مقادیر را به درستی واردی نمایید");
            }
            else
            {
                MessageBox.Show("کاربر گرامی دستگاه شما به اینترنت متصل نیست");
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

        private void GetRoleType(int userId)
        {
            UserRoleType userRoleType = new UserRoleType();
            userRoleType.Attach(this);
            userRoleType.GetUserRoleId(userId);
        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            if(requestCode == RequestCodes.UserSignedIn)
            {
                int result = int.Parse(response.ToString());
                if (result > 0)
                {
                    Program.UserId = int.Parse(response.ToString());
                    GetRoleType(int.Parse(response.ToString()));
                }
                else if (result == (int)LoginStatus.WrongPasswordOrUserName)
                {
                    MessageBox.Show("نام کاربری یا گذرواژه اشتباه است");
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
    }
}
