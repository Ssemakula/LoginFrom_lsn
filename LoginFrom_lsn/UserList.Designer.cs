namespace LoginFrom_lsn
{
    partial class UserList
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
            this.users = new LoginFrom_lsn.Users();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LoginFrom_lsn.UsersTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new LoginFrom_lsn.UsersTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.users;
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
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.UserPass,
            this.FirstName,
            this.LastName,
            this.CellNumber,
            this.Landline,
            this.Email,
            this.WebSite,
            this.Address,
            this.Comments,
            this.UserImage});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 10;
            this.usersDataGridView.RowTemplate.Height = 50;
            this.usersDataGridView.Size = new System.Drawing.Size(606, 374);
            this.usersDataGridView.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Username";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // UserPass
            // 
            this.UserPass.DataPropertyName = "UserPass";
            this.UserPass.HeaderText = "Password";
            this.UserPass.Name = "UserPass";
            this.UserPass.ReadOnly = true;
            this.UserPass.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // CellNumber
            // 
            this.CellNumber.DataPropertyName = "CellNumber";
            this.CellNumber.HeaderText = "Cell";
            this.CellNumber.Name = "CellNumber";
            this.CellNumber.ReadOnly = true;
            this.CellNumber.Visible = false;
            // 
            // Landline
            // 
            this.Landline.DataPropertyName = "Landline";
            this.Landline.HeaderText = "Landline";
            this.Landline.Name = "Landline";
            this.Landline.ReadOnly = true;
            this.Landline.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // WebSite
            // 
            this.WebSite.DataPropertyName = "WebSite";
            this.WebSite.HeaderText = "WebSite";
            this.WebSite.Name = "WebSite";
            this.WebSite.ReadOnly = true;
            this.WebSite.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Visible = false;
            // 
            // UserImage
            // 
            this.UserImage.DataPropertyName = "UserImage";
            this.UserImage.HeaderText = "UserImage";
            this.UserImage.Name = "UserImage";
            this.UserImage.ReadOnly = true;
            this.UserImage.Width = 150;
            // 
            // editButton
            // 
            this.editButton.Image = global::LoginFrom_lsn.Properties.Resources._7388_forum_friends_group_member_people_icon;
            this.editButton.Location = new System.Drawing.Point(12, 392);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 48);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Add/Edit Users";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.usersDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Users users;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Landline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewImageColumn UserImage;
    }
}