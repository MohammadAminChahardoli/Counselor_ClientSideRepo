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
    public partial class UserRegisterationForm : Form
    {
        public UserRegisterationForm()
        {
            InitializeComponent();
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultationRecipientForm recipientForm = new ConsultationRecipientForm();
            recipientForm.Show();
        }
    }
}
