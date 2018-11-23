namespace CounselorClient.Forms
{
    partial class ConsultationRecipientForm
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
            this.listBoxConsulators = new System.Windows.Forms.ListBox();
            this.labelConsulatorsListCaption = new System.Windows.Forms.Label();
            this.labelChatsCaption = new System.Windows.Forms.Label();
            this.listBoxChats = new System.Windows.Forms.ListBox();
            this.labelMessagesCaption = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxConsulators
            // 
            this.listBoxConsulators.FormattingEnabled = true;
            this.listBoxConsulators.ItemHeight = 22;
            this.listBoxConsulators.Items.AddRange(new object[] {
            "رضایی",
            "محمدی",
            "کاظمی",
            "میلانی",
            "حجتی"});
            this.listBoxConsulators.Location = new System.Drawing.Point(698, 56);
            this.listBoxConsulators.Name = "listBoxConsulators";
            this.listBoxConsulators.Size = new System.Drawing.Size(190, 422);
            this.listBoxConsulators.TabIndex = 0;
            // 
            // labelConsulatorsListCaption
            // 
            this.labelConsulatorsListCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConsulatorsListCaption.BackColor = System.Drawing.Color.Linen;
            this.labelConsulatorsListCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelConsulatorsListCaption.Location = new System.Drawing.Point(698, 9);
            this.labelConsulatorsListCaption.Name = "labelConsulatorsListCaption";
            this.labelConsulatorsListCaption.Size = new System.Drawing.Size(190, 43);
            this.labelConsulatorsListCaption.TabIndex = 2;
            this.labelConsulatorsListCaption.Text = "لیست مشاورین";
            this.labelConsulatorsListCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChatsCaption
            // 
            this.labelChatsCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChatsCaption.BackColor = System.Drawing.Color.Linen;
            this.labelChatsCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelChatsCaption.Location = new System.Drawing.Point(492, 9);
            this.labelChatsCaption.Name = "labelChatsCaption";
            this.labelChatsCaption.Size = new System.Drawing.Size(190, 43);
            this.labelChatsCaption.TabIndex = 4;
            this.labelChatsCaption.Text = "لیست چت ها";
            this.labelChatsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxChats
            // 
            this.listBoxChats.FormattingEnabled = true;
            this.listBoxChats.ItemHeight = 22;
            this.listBoxChats.Items.AddRange(new object[] {
            "چت یک",
            "چت دو",
            "چت سه",
            "چت چهار",
            "چت پنج",
            "چت شش",
            "چت هفت"});
            this.listBoxChats.Location = new System.Drawing.Point(492, 56);
            this.listBoxChats.Name = "listBoxChats";
            this.listBoxChats.Size = new System.Drawing.Size(190, 422);
            this.listBoxChats.TabIndex = 3;
            // 
            // labelMessagesCaption
            // 
            this.labelMessagesCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessagesCaption.BackColor = System.Drawing.Color.Linen;
            this.labelMessagesCaption.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelMessagesCaption.Location = new System.Drawing.Point(12, 9);
            this.labelMessagesCaption.Name = "labelMessagesCaption";
            this.labelMessagesCaption.Size = new System.Drawing.Size(462, 43);
            this.labelMessagesCaption.TabIndex = 6;
            this.labelMessagesCaption.Text = "لیست پیام ها";
            this.labelMessagesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 22;
            this.listBoxMessages.Items.AddRange(new object[] {
            "سلام",
            "سلام",
            "خوبی",
            "خوبم",
            "خب باشه"});
            this.listBoxMessages.Location = new System.Drawing.Point(12, 56);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(462, 422);
            this.listBoxMessages.TabIndex = 5;
            // 
            // ConsultationRecipientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.labelMessagesCaption);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.labelChatsCaption);
            this.Controls.Add(this.listBoxChats);
            this.Controls.Add(this.labelConsulatorsListCaption);
            this.Controls.Add(this.listBoxConsulators);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "ConsultationRecipientForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxConsulators;
        private System.Windows.Forms.Label labelConsulatorsListCaption;
        private System.Windows.Forms.Label labelChatsCaption;
        private System.Windows.Forms.ListBox listBoxChats;
        private System.Windows.Forms.Label labelMessagesCaption;
        private System.Windows.Forms.ListBox listBoxMessages;
    }
}