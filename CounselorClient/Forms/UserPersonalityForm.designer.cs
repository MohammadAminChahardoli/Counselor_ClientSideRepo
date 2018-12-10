namespace CounselorClient.Forms
{
    partial class UserPersonalityForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFamousCharacters = new System.Windows.Forms.Label();
            this.lblKeyAttribute = new System.Windows.Forms.Label();
            this.lblPersonalityTitle = new System.Windows.Forms.Label();
            this.lblWeakPoints = new System.Windows.Forms.Label();
            this.lblStrenghtsPoints = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProperJobs = new System.Windows.Forms.Label();
            this.lblRelationsWithOthers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(833, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFamousCharacters
            // 
            this.lblFamousCharacters.BackColor = System.Drawing.Color.FloralWhite;
            this.lblFamousCharacters.Location = new System.Drawing.Point(398, 207);
            this.lblFamousCharacters.Name = "lblFamousCharacters";
            this.lblFamousCharacters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFamousCharacters.Size = new System.Drawing.Size(380, 190);
            this.lblFamousCharacters.TabIndex = 1;
            this.lblFamousCharacters.Text = "اشخاص معروف";
            this.lblFamousCharacters.Click += new System.EventHandler(this.lblFamousCharacters_Click);
            // 
            // lblKeyAttribute
            // 
            this.lblKeyAttribute.BackColor = System.Drawing.Color.FloralWhite;
            this.lblKeyAttribute.Location = new System.Drawing.Point(12, 14);
            this.lblKeyAttribute.Name = "lblKeyAttribute";
            this.lblKeyAttribute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKeyAttribute.Size = new System.Drawing.Size(380, 190);
            this.lblKeyAttribute.TabIndex = 2;
            this.lblKeyAttribute.Text = "صفات کلیدی";
            // 
            // lblPersonalityTitle
            // 
            this.lblPersonalityTitle.AutoSize = true;
            this.lblPersonalityTitle.Location = new System.Drawing.Point(842, 126);
            this.lblPersonalityTitle.Name = "lblPersonalityTitle";
            this.lblPersonalityTitle.Size = new System.Drawing.Size(114, 22);
            this.lblPersonalityTitle.TabIndex = 4;
            this.lblPersonalityTitle.Text = "عنوان تیپ شخصیتی";
            // 
            // lblWeakPoints
            // 
            this.lblWeakPoints.BackColor = System.Drawing.Color.FloralWhite;
            this.lblWeakPoints.Location = new System.Drawing.Point(12, 207);
            this.lblWeakPoints.Name = "lblWeakPoints";
            this.lblWeakPoints.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeakPoints.Size = new System.Drawing.Size(380, 190);
            this.lblWeakPoints.TabIndex = 6;
            this.lblWeakPoints.Text = "نقاط ضعف";
            // 
            // lblStrenghtsPoints
            // 
            this.lblStrenghtsPoints.BackColor = System.Drawing.Color.FloralWhite;
            this.lblStrenghtsPoints.Location = new System.Drawing.Point(398, 14);
            this.lblStrenghtsPoints.Name = "lblStrenghtsPoints";
            this.lblStrenghtsPoints.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStrenghtsPoints.Size = new System.Drawing.Size(380, 190);
            this.lblStrenghtsPoints.TabIndex = 5;
            this.lblStrenghtsPoints.Text = "نقاط قوت";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblProperJobs);
            this.panel1.Controls.Add(this.lblRelationsWithOthers);
            this.panel1.Controls.Add(this.lblFamousCharacters);
            this.panel1.Controls.Add(this.lblWeakPoints);
            this.panel1.Controls.Add(this.lblKeyAttribute);
            this.panel1.Controls.Add(this.lblStrenghtsPoints);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 605);
            this.panel1.TabIndex = 7;
            // 
            // lblProperJobs
            // 
            this.lblProperJobs.BackColor = System.Drawing.Color.FloralWhite;
            this.lblProperJobs.Location = new System.Drawing.Point(12, 401);
            this.lblProperJobs.Name = "lblProperJobs";
            this.lblProperJobs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProperJobs.Size = new System.Drawing.Size(380, 190);
            this.lblProperJobs.TabIndex = 8;
            this.lblProperJobs.Text = "مشاغل مناسب";
            // 
            // lblRelationsWithOthers
            // 
            this.lblRelationsWithOthers.BackColor = System.Drawing.Color.FloralWhite;
            this.lblRelationsWithOthers.Location = new System.Drawing.Point(398, 401);
            this.lblRelationsWithOthers.Name = "lblRelationsWithOthers";
            this.lblRelationsWithOthers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRelationsWithOthers.Size = new System.Drawing.Size(380, 190);
            this.lblRelationsWithOthers.TabIndex = 7;
            this.lblRelationsWithOthers.Text = "روابط با دیگران";
            // 
            // UserPersonalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPersonalityTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UserPersonalityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تیپ شخصیتی";
            this.Load += new System.EventHandler(this.UserPersonalityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFamousCharacters;
        private System.Windows.Forms.Label lblKeyAttribute;
        private System.Windows.Forms.Label lblPersonalityTitle;
        private System.Windows.Forms.Label lblWeakPoints;
        private System.Windows.Forms.Label lblStrenghtsPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProperJobs;
        private System.Windows.Forms.Label lblRelationsWithOthers;
    }
}