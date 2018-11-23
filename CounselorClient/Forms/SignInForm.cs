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
    public partial class SignInForm : Form
    {
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
            this.Hide();
            ConsultationRecipientForm recipientForm = new ConsultationRecipientForm();
            recipientForm.Show();
        }
    }
}
