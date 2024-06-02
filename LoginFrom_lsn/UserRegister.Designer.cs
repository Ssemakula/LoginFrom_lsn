namespace LoginFrom_lsn
{
    partial class UserRegister
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userPassLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label cellNumberLabel;
            System.Windows.Forms.Label landlineLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label webSiteLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.userImageButton = new System.Windows.Forms.Button();
            this.rptPassLabel = new System.Windows.Forms.Label();
            this.rptPassTextBox = new System.Windows.Forms.TextBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users = new LoginFrom_lsn.Users();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPassTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cellNumberTextBox = new System.Windows.Forms.TextBox();
            this.landlineTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.webSiteTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new LoginFrom_lsn.UsersTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new LoginFrom_lsn.UsersTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userPassLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            cellNumberLabel = new System.Windows.Forms.Label();
            landlineLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            webSiteLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(20, 28);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(211, 28);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name:";
            // 
            // userPassLabel
            // 
            userPassLabel.AutoSize = true;
            userPassLabel.Location = new System.Drawing.Point(20, 54);
            userPassLabel.Name = "userPassLabel";
            userPassLabel.Size = new System.Drawing.Size(58, 13);
            userPassLabel.TabIndex = 4;
            userPassLabel.Text = "User Pass:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 80);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(211, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            // 
            // cellNumberLabel
            // 
            cellNumberLabel.AutoSize = true;
            cellNumberLabel.Location = new System.Drawing.Point(20, 106);
            cellNumberLabel.Name = "cellNumberLabel";
            cellNumberLabel.Size = new System.Drawing.Size(67, 13);
            cellNumberLabel.TabIndex = 12;
            cellNumberLabel.Text = "Cell Number:";
            // 
            // landlineLabel
            // 
            landlineLabel.AutoSize = true;
            landlineLabel.Location = new System.Drawing.Point(211, 106);
            landlineLabel.Name = "landlineLabel";
            landlineLabel.Size = new System.Drawing.Size(50, 13);
            landlineLabel.TabIndex = 14;
            landlineLabel.Text = "Landline:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(20, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.Location = new System.Drawing.Point(211, 132);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(54, 13);
            webSiteLabel.TabIndex = 18;
            webSiteLabel.Text = "Web Site:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(20, 158);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 20;
            addressLabel.Text = "Address:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(20, 200);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 22;
            commentsLabel.Text = "Comments:";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.cancelButton);
            this.menuPanel.Controls.Add(this.deleteButton);
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Controls.Add(this.editButton);
            this.menuPanel.Controls.Add(this.newButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(556, 60);
            this.menuPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Image = global::LoginFrom_lsn.Properties.Resources._10583_exit_power_icon;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(481, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::LoginFrom_lsn.Properties.Resources.cancel_butt;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelButton.Location = new System.Drawing.Point(284, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 51);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::LoginFrom_lsn.Properties.Resources.Delete_butt;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.Location = new System.Drawing.Point(144, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 51);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::LoginFrom_lsn.Properties.Resources.floppy_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveButton.Location = new System.Drawing.Point(214, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 51);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Image = global::LoginFrom_lsn.Properties.Resources.add_memo;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editButton.Location = new System.Drawing.Point(74, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(70, 51);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit User";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Image = global::LoginFrom_lsn.Properties.Resources.reg_butt;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newButton.Location = new System.Drawing.Point(4, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(70, 51);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New User";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.userImageButton);
            this.infoGroupBox.Controls.Add(this.rptPassLabel);
            this.infoGroupBox.Controls.Add(this.rptPassTextBox);
            this.infoGroupBox.Controls.Add(this.userPictureBox);
            this.infoGroupBox.Controls.Add(iDLabel);
            this.infoGroupBox.Controls.Add(this.iDTextBox);
            this.infoGroupBox.Controls.Add(userNameLabel);
            this.infoGroupBox.Controls.Add(this.userNameTextBox);
            this.infoGroupBox.Controls.Add(userPassLabel);
            this.infoGroupBox.Controls.Add(this.userPassTextBox);
            this.infoGroupBox.Controls.Add(firstNameLabel);
            this.infoGroupBox.Controls.Add(this.firstNameTextBox);
            this.infoGroupBox.Controls.Add(lastNameLabel);
            this.infoGroupBox.Controls.Add(this.lastNameTextBox);
            this.infoGroupBox.Controls.Add(cellNumberLabel);
            this.infoGroupBox.Controls.Add(this.cellNumberTextBox);
            this.infoGroupBox.Controls.Add(landlineLabel);
            this.infoGroupBox.Controls.Add(this.landlineTextBox);
            this.infoGroupBox.Controls.Add(emailLabel);
            this.infoGroupBox.Controls.Add(this.emailTextBox);
            this.infoGroupBox.Controls.Add(webSiteLabel);
            this.infoGroupBox.Controls.Add(this.webSiteTextBox);
            this.infoGroupBox.Controls.Add(addressLabel);
            this.infoGroupBox.Controls.Add(this.addressTextBox);
            this.infoGroupBox.Controls.Add(commentsLabel);
            this.infoGroupBox.Controls.Add(this.commentsTextBox);
            this.infoGroupBox.Location = new System.Drawing.Point(6, 88);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(544, 315);
            this.infoGroupBox.TabIndex = 0;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Infomation";
            // 
            // userImageButton
            // 
            this.userImageButton.Location = new System.Drawing.Point(415, 171);
            this.userImageButton.Name = "userImageButton";
            this.userImageButton.Size = new System.Drawing.Size(108, 23);
            this.userImageButton.TabIndex = 24;
            this.userImageButton.Text = "Change Image";
            this.userImageButton.UseVisualStyleBackColor = true;
            this.userImageButton.Click += new System.EventHandler(this.UserImageButton_Click);
            // 
            // rptPassLabel
            // 
            this.rptPassLabel.AutoSize = true;
            this.rptPassLabel.Location = new System.Drawing.Point(211, 54);
            this.rptPassLabel.Name = "rptPassLabel";
            this.rptPassLabel.Size = new System.Drawing.Size(70, 13);
            this.rptPassLabel.TabIndex = 6;
            this.rptPassLabel.Text = "Repeat pass:";
            // 
            // rptPassTextBox
            // 
            this.rptPassTextBox.Location = new System.Drawing.Point(284, 50);
            this.rptPassTextBox.Name = "rptPassTextBox";
            this.rptPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.rptPassTextBox.TabIndex = 7;
            // 
            // userPictureBox
            // 
            this.userPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "UserImage", true));
            this.userPictureBox.Location = new System.Drawing.Point(415, 25);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(108, 144);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 22;
            this.userPictureBox.TabStop = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(93, 24);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.users;
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(284, 24);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // userPassTextBox
            // 
            this.userPassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserPass", true));
            this.userPassTextBox.Location = new System.Drawing.Point(93, 50);
            this.userPassTextBox.Name = "userPassTextBox";
            this.userPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.userPassTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(93, 76);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(284, 76);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // cellNumberTextBox
            // 
            this.cellNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "CellNumber", true));
            this.cellNumberTextBox.Location = new System.Drawing.Point(93, 102);
            this.cellNumberTextBox.Name = "cellNumberTextBox";
            this.cellNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.cellNumberTextBox.TabIndex = 13;
            // 
            // landlineTextBox
            // 
            this.landlineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Landline", true));
            this.landlineTextBox.Location = new System.Drawing.Point(284, 102);
            this.landlineTextBox.Name = "landlineTextBox";
            this.landlineTextBox.Size = new System.Drawing.Size(100, 20);
            this.landlineTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(93, 128);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 17;
            // 
            // webSiteTextBox
            // 
            this.webSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "WebSite", true));
            this.webSiteTextBox.Location = new System.Drawing.Point(284, 128);
            this.webSiteTextBox.Name = "webSiteTextBox";
            this.webSiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.webSiteTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(93, 154);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 21;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(93, 197);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(430, 108);
            this.commentsTextBox.TabIndex = 23;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LoginFrom_lsn.UsersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 409);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Users";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            this.menuPanel.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private Users users;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPassTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox cellNumberTextBox;
        private System.Windows.Forms.TextBox landlineTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox webSiteTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox rptPassTextBox;
        private System.Windows.Forms.Label rptPassLabel;
        private System.Windows.Forms.Button userImageButton;
    }
}