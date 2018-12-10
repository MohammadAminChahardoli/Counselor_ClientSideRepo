namespace CounselorClient.Forms
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.labelRegisterCaption = new System.Windows.Forms.Label();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.labelٌ1 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelWating = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegisterCaption
            // 
            this.labelRegisterCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisterCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelRegisterCaption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelRegisterCaption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegisterCaption.Location = new System.Drawing.Point(-2, -1);
            this.labelRegisterCaption.Name = "labelRegisterCaption";
            this.labelRegisterCaption.Size = new System.Drawing.Size(339, 43);
            this.labelRegisterCaption.TabIndex = 1;
            this.labelRegisterCaption.Text = "ورود به حساب کاربری";
            this.labelRegisterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.BackColor = System.Drawing.Color.Linen;
            this.linkLabelSignUp.Font = new System.Drawing.Font("IRANSans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabelSignUp.Location = new System.Drawing.Point(26, 551);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(39, 18);
            this.linkLabelSignUp.TabIndex = 23;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "ثبت نام";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // labelٌ1
            // 
            this.labelٌ1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelٌ1.BackColor = System.Drawing.Color.Snow;
            this.labelٌ1.Font = new System.Drawing.Font("IRANSans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelٌ1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.labelٌ1.Location = new System.Drawing.Point(-34, 536);
            this.labelٌ1.Name = "labelٌ1";
            this.labelٌ1.Size = new System.Drawing.Size(381, 53);
            this.labelٌ1.TabIndex = 22;
            this.labelٌ1.Text = "      کاربر گرامی اگر قبلا ثبت نام نکرده اید، ابتدا ثبت نام کنید.";
            this.labelٌ1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(108, 434);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(117, 31);
            this.buttonSignIn.TabIndex = 21;
            this.buttonSignIn.Text = "ورود";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(265, 379);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 22);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "رمز عبور";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(64, 372);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(183, 29);
            this.textBoxPassword.TabIndex = 19;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(265, 325);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(56, 22);
            this.labelUserName.TabIndex = 18;
            this.labelUserName.Text = "نام کاربری";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(64, 322);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(183, 29);
            this.textBoxUserName.TabIndex = 17;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWating
            // 
            this.labelWating.AutoSize = true;
            this.labelWating.ForeColor = System.Drawing.Color.Gold;
            this.labelWating.Location = new System.Drawing.Point(87, 471);
            this.labelWating.Name = "labelWating";
            this.labelWating.Size = new System.Drawing.Size(153, 22);
            this.labelWating.TabIndex = 24;
            this.labelWating.Text = "کاربر گرامی لطفا منتظر بمانید.";
            this.labelWating.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CounselorClient.Properties.Resources.photo_2018_12_03_21_03_29;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 576);
            this.Controls.Add(this.labelWating);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.labelٌ1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelRegisterCaption);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegisterCaption;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Label labelٌ1;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelWating;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}