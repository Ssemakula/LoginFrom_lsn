namespace LoginFrom_lsn
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.inboxButton = new System.Windows.Forms.Button();
            this.sendSMSButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.skinButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.dividerPanel);
            this.mainPanel.Controls.Add(this.userLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.helpButton);
            this.mainPanel.Controls.Add(this.usersButton);
            this.mainPanel.Controls.Add(this.reportsButton);
            this.mainPanel.Controls.Add(this.settingsButton);
            this.mainPanel.Controls.Add(this.inboxButton);
            this.mainPanel.Controls.Add(this.sendSMSButton);
            this.mainPanel.Controls.Add(this.dataButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 61);
            this.mainPanel.TabIndex = 0;
            // 
            // dividerPanel
            // 
            this.dividerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dividerPanel.Location = new System.Drawing.Point(175, -13);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(2, 100);
            this.dividerPanel.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.Location = new System.Drawing.Point(106, 4);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(63, 50);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "label1";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(4, 4);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(95, 50);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 8;
            this.userPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::LoginFrom_lsn.Properties.Resources._10583_exit_power_icon;
            this.exitButton.Location = new System.Drawing.Point(854, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 53);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Image = global::LoginFrom_lsn.Properties.Resources._2303194_circle_faq_help_information_mark_icon;
            this.helpButton.Location = new System.Drawing.Point(758, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(92, 53);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Help";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // usersButton
            // 
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Image = global::LoginFrom_lsn.Properties.Resources._7388_forum_friends_group_member_people_icon;
            this.usersButton.Location = new System.Drawing.Point(662, 3);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(92, 53);
            this.usersButton.TabIndex = 5;
            this.usersButton.Text = "Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.Image = global::LoginFrom_lsn.Properties.Resources._7038097_marketing_file_business_clipboard_data_icon;
            this.reportsButton.Location = new System.Drawing.Point(566, 3);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(92, 53);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Image = global::LoginFrom_lsn.Properties.Resources._2530802_cog_gear_general_machine_office_icon;
            this.settingsButton.Location = new System.Drawing.Point(470, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(92, 53);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // inboxButton
            // 
            this.inboxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inboxButton.Image = global::LoginFrom_lsn.Properties.Resources._4171273_day_heart_love_sms_valentine_icon;
            this.inboxButton.Location = new System.Drawing.Point(374, 3);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Size = new System.Drawing.Size(92, 53);
            this.inboxButton.TabIndex = 2;
            this.inboxButton.Text = "Inbox";
            this.inboxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inboxButton.UseVisualStyleBackColor = true;
            // 
            // sendSMSButton
            // 
            this.sendSMSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendSMSButton.Image = global::LoginFrom_lsn.Properties.Resources._43332_sms_icon;
            this.sendSMSButton.Location = new System.Drawing.Point(278, 3);
            this.sendSMSButton.Name = "sendSMSButton";
            this.sendSMSButton.Size = new System.Drawing.Size(92, 53);
            this.sendSMSButton.TabIndex = 1;
            this.sendSMSButton.Text = "Send SMS";
            this.sendSMSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sendSMSButton.UseVisualStyleBackColor = true;
            // 
            // dataButton
            // 
            this.dataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataButton.Image = global::LoginFrom_lsn.Properties.Resources._8542038_download_data_icon;
            this.dataButton.Location = new System.Drawing.Point(182, 3);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(92, 53);
            this.dataButton.TabIndex = 0;
            this.dataButton.Text = "Data";
            this.dataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dataButton.UseVisualStyleBackColor = true;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.backgroundButton);
            this.infoPanel.Controls.Add(this.skinButton);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 501);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(960, 31);
            this.infoPanel.TabIndex = 1;
            // 
            // backgroundButton
            // 
            this.backgroundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundButton.Location = new System.Drawing.Point(799, 2);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundButton.TabIndex = 1;
            this.backgroundButton.Text = "Background";
            this.backgroundButton.UseVisualStyleBackColor = true;
            // 
            // skinButton
            // 
            this.skinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton.Location = new System.Drawing.Point(878, 2);
            this.skinButton.Name = "skinButton";
            this.skinButton.Size = new System.Drawing.Size(75, 23);
            this.skinButton.TabIndex = 0;
            this.skinButton.Text = "Skin";
            this.skinButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 532);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.mainPanel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button inboxButton;
        private System.Windows.Forms.Button sendSMSButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button skinButton;
        private System.Windows.Forms.Panel dividerPanel;
        public System.Windows.Forms.PictureBox userPictureBox;
        public System.Windows.Forms.Label userLabel;
    }
}

