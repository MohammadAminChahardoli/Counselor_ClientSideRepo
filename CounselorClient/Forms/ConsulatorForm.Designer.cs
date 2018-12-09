namespace CounselorClient.Forms
{
    partial class ConsulatorForm
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
            this.labelMessagesCaption = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.labelChatsCaption = new System.Windows.Forms.Label();
            this.listBoxChats = new System.Windows.Forms.ListBox();
            this.labelQuestionsListCaption = new System.Windows.Forms.Label();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.labelWating = new System.Windows.Forms.Label();
            this.labelUserCaption = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessagesCaption
            // 
            this.labelMessagesCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessagesCaption.BackColor = System.Drawing.Color.Linen;
            this.labelMessagesCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelMessagesCaption.Location = new System.Drawing.Point(479, 26);
            this.labelMessagesCaption.Name = "labelMessagesCaption";
            this.labelMessagesCaption.Size = new System.Drawing.Size(685, 26);
            this.labelMessagesCaption.TabIndex = 12;
            this.labelMessagesCaption.Text = " پیام ها";
            this.labelMessagesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.HorizontalScrollbar = true;
            this.listBoxMessages.ItemHeight = 22;
            this.listBoxMessages.Location = new System.Drawing.Point(479, 52);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(685, 334);
            this.listBoxMessages.TabIndex = 11;
            // 
            // labelChatsCaption
            // 
            this.labelChatsCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChatsCaption.BackColor = System.Drawing.Color.Linen;
            this.labelChatsCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelChatsCaption.Location = new System.Drawing.Point(283, 26);
            this.labelChatsCaption.Name = "labelChatsCaption";
            this.labelChatsCaption.Size = new System.Drawing.Size(190, 26);
            this.labelChatsCaption.TabIndex = 10;
            this.labelChatsCaption.Text = " گفتگو ها";
            this.labelChatsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxChats
            // 
            this.listBoxChats.FormattingEnabled = true;
            this.listBoxChats.HorizontalScrollbar = true;
            this.listBoxChats.ItemHeight = 22;
            this.listBoxChats.Location = new System.Drawing.Point(283, 53);
            this.listBoxChats.Name = "listBoxChats";
            this.listBoxChats.Size = new System.Drawing.Size(190, 334);
            this.listBoxChats.TabIndex = 9;
            this.listBoxChats.SelectedIndexChanged += new System.EventHandler(this.listBoxChats_SelectedIndexChanged);
            // 
            // labelQuestionsListCaption
            // 
            this.labelQuestionsListCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestionsListCaption.BackColor = System.Drawing.Color.Linen;
            this.labelQuestionsListCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelQuestionsListCaption.Location = new System.Drawing.Point(12, 404);
            this.labelQuestionsListCaption.Name = "labelQuestionsListCaption";
            this.labelQuestionsListCaption.Size = new System.Drawing.Size(1152, 26);
            this.labelQuestionsListCaption.TabIndex = 8;
            this.labelQuestionsListCaption.Text = " سوالات";
            this.labelQuestionsListCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.HorizontalScrollbar = true;
            this.listBoxQuestions.ItemHeight = 22;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 430);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(1152, 180);
            this.listBoxQuestions.TabIndex = 7;
            // 
            // labelWating
            // 
            this.labelWating.AutoSize = true;
            this.labelWating.ForeColor = System.Drawing.Color.Gold;
            this.labelWating.Location = new System.Drawing.Point(533, 0);
            this.labelWating.Name = "labelWating";
            this.labelWating.Size = new System.Drawing.Size(153, 22);
            this.labelWating.TabIndex = 25;
            this.labelWating.Text = "کاربر گرامی لطفا منتظر بمانید.";
            this.labelWating.Visible = false;
            // 
            // labelUserCaption
            // 
            this.labelUserCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserCaption.BackColor = System.Drawing.Color.Linen;
            this.labelUserCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelUserCaption.Location = new System.Drawing.Point(12, 26);
            this.labelUserCaption.Name = "labelUserCaption";
            this.labelUserCaption.Size = new System.Drawing.Size(190, 26);
            this.labelUserCaption.TabIndex = 27;
            this.labelUserCaption.Text = " کاربران";
            this.labelUserCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.HorizontalScrollbar = true;
            this.listBoxUsers.ItemHeight = 22;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 53);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(190, 334);
            this.listBoxUsers.TabIndex = 26;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(1089, 612);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(75, 32);
            this.buttonSendMessage.TabIndex = 28;
            this.buttonSendMessage.Text = "ارسال پیام";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // ConsulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1176, 647);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.labelUserCaption);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.labelWating);
            this.Controls.Add(this.labelMessagesCaption);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.labelChatsCaption);
            this.Controls.Add(this.listBoxChats);
            this.Controls.Add(this.labelQuestionsListCaption);
            this.Controls.Add(this.listBoxQuestions);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "ConsulatorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsulatorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessagesCaption;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label labelChatsCaption;
        private System.Windows.Forms.ListBox listBoxChats;
        private System.Windows.Forms.Label labelQuestionsListCaption;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label labelWating;
        private System.Windows.Forms.Label labelUserCaption;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}