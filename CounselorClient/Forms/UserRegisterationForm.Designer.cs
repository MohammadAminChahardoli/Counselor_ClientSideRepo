namespace CounselorClient.Forms
{
    partial class UserRegisterationForm
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
            this.labelRegisterCaption = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.labelMajore = new System.Windows.Forms.Label();
            this.textBoxMajore = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelRegisterCaption
            // 
            this.labelRegisterCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisterCaption.BackColor = System.Drawing.Color.Linen;
            this.labelRegisterCaption.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelRegisterCaption.Location = new System.Drawing.Point(-5, -2);
            this.labelRegisterCaption.Name = "labelRegisterCaption";
            this.labelRegisterCaption.Size = new System.Drawing.Size(339, 43);
            this.labelRegisterCaption.TabIndex = 0;
            this.labelRegisterCaption.Text = "ثبت نام";
            this.labelRegisterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(52, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(251, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(23, 22);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "نام";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(251, 120);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(71, 22);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "نام خانوادگی";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(52, 113);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(183, 29);
            this.textBoxFamily.TabIndex = 3;
            this.textBoxFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMajore
            // 
            this.labelMajore.AutoSize = true;
            this.labelMajore.Location = new System.Drawing.Point(253, 165);
            this.labelMajore.Name = "labelMajore";
            this.labelMajore.Size = new System.Drawing.Size(78, 22);
            this.labelMajore.TabIndex = 6;
            this.labelMajore.Text = "رشته تحصیلی";
            // 
            // textBoxMajore
            // 
            this.textBoxMajore.Location = new System.Drawing.Point(52, 162);
            this.textBoxMajore.Name = "textBoxMajore";
            this.textBoxMajore.Size = new System.Drawing.Size(183, 29);
            this.textBoxMajore.TabIndex = 5;
            this.textBoxMajore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(253, 215);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 22);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "سن";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(52, 208);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(183, 29);
            this.textBoxAge.TabIndex = 7;
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(253, 257);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(56, 22);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "نام کاربری";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(52, 254);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(183, 29);
            this.textBoxUserName.TabIndex = 9;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(253, 311);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 22);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "رمز عبور";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(52, 304);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(183, 29);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(100, 356);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(117, 31);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "ثبت نام";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("IRANSans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(-35, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "      کاربر گرامی اگر قبلا ثبت نام کرده اید، وارد شوید.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelSignIn
            // 
            this.linkLabelSignIn.AutoSize = true;
            this.linkLabelSignIn.BackColor = System.Drawing.Color.Linen;
            this.linkLabelSignIn.Font = new System.Drawing.Font("IRANSans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabelSignIn.Location = new System.Drawing.Point(29, 434);
            this.linkLabelSignIn.Name = "linkLabelSignIn";
            this.linkLabelSignIn.Size = new System.Drawing.Size(95, 18);
            this.linkLabelSignIn.TabIndex = 16;
            this.linkLabelSignIn.TabStop = true;
            this.linkLabelSignIn.Text = "ورود به حساب کاربری";
            this.linkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignIn_LinkClicked);
            // 
            // UserRegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.linkLabelSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelMajore);
            this.Controls.Add(this.textBoxMajore);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelRegisterCaption);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "UserRegisterationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegisterCaption;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.Label labelMajore;
        private System.Windows.Forms.TextBox textBoxMajore;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelSignIn;
    }
}