namespace LoginFrom_lsn
{
    partial class ProductList
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label uOMLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label sysDateLabel;
            System.Windows.Forms.Label sysTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users = new LoginFrom_lsn.Users();
            this.uOMTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.sysTimeLabel1 = new System.Windows.Forms.Label();
            this.sysDateLabel1 = new System.Windows.Forms.Label();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.userIDLabel1 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new LoginFrom_lsn.UsersTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new LoginFrom_lsn.UsersTableAdapters.TableAdapterManager();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            uOMLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            sysDateLabel = new System.Windows.Forms.Label();
            sysTimeLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(76, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(17, 61);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(238, 61);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(406, 61);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Quantity:";
            // 
            // uOMLabel
            // 
            uOMLabel.AutoSize = true;
            uOMLabel.Location = new System.Drawing.Point(60, 97);
            uOMLabel.Name = "uOMLabel";
            uOMLabel.Size = new System.Drawing.Size(35, 13);
            uOMLabel.TabIndex = 8;
            uOMLabel.Text = "UOM:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(213, 100);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 10;
            commentsLabel.Text = "Comments:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(14, 10);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "User ID:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(132, 10);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name:";
            // 
            // sysDateLabel
            // 
            sysDateLabel.AutoSize = true;
            sysDateLabel.Location = new System.Drawing.Point(295, 10);
            sysDateLabel.Name = "sysDateLabel";
            sysDateLabel.Size = new System.Drawing.Size(53, 13);
            sysDateLabel.TabIndex = 4;
            sysDateLabel.Text = "Sys Date:";
            // 
            // sysTimeLabel
            // 
            sysTimeLabel.AutoSize = true;
            sysTimeLabel.Location = new System.Drawing.Point(448, 10);
            sysTimeLabel.Name = "sysTimeLabel";
            sysTimeLabel.Size = new System.Drawing.Size(53, 13);
            sysTimeLabel.TabIndex = 6;
            sysTimeLabel.Text = "Sys Time:";
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
            this.menuPanel.Size = new System.Drawing.Size(618, 60);
            this.menuPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Image = global::LoginFrom_lsn.Properties.Resources._10583_exit_power_icon;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(520, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 51);
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
            this.cancelButton.Location = new System.Drawing.Point(372, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 51);
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
            this.deleteButton.Location = new System.Drawing.Point(188, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 51);
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
            this.saveButton.Location = new System.Drawing.Point(280, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 51);
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
            this.editButton.Location = new System.Drawing.Point(96, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 51);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Product";
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
            this.newButton.Size = new System.Drawing.Size(92, 51);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New Product";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(commentsLabel);
            this.infoGroupBox.Controls.Add(this.commentsTextBox);
            this.infoGroupBox.Controls.Add(uOMLabel);
            this.infoGroupBox.Controls.Add(this.uOMTextBox);
            this.infoGroupBox.Controls.Add(quantityLabel);
            this.infoGroupBox.Controls.Add(this.quantityTextBox);
            this.infoGroupBox.Controls.Add(priceLabel);
            this.infoGroupBox.Controls.Add(this.priceTextBox);
            this.infoGroupBox.Controls.Add(productNameLabel);
            this.infoGroupBox.Controls.Add(this.productNameTextBox);
            this.infoGroupBox.Controls.Add(idLabel);
            this.infoGroupBox.Controls.Add(this.idTextBox);
            this.infoGroupBox.Location = new System.Drawing.Point(13, 66);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(589, 189);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Products";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(278, 97);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(283, 83);
            this.commentsTextBox.TabIndex = 11;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.users;
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uOMTextBox
            // 
            this.uOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UOM", true));
            this.uOMTextBox.Location = new System.Drawing.Point(101, 94);
            this.uOMTextBox.Name = "uOMTextBox";
            this.uOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.uOMTextBox.TabIndex = 9;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(461, 57);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(278, 57);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(101, 57);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(101, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(sysTimeLabel);
            this.infoPanel.Controls.Add(this.sysTimeLabel1);
            this.infoPanel.Controls.Add(sysDateLabel);
            this.infoPanel.Controls.Add(this.sysDateLabel1);
            this.infoPanel.Controls.Add(userNameLabel);
            this.infoPanel.Controls.Add(this.userNameLabel1);
            this.infoPanel.Controls.Add(userIDLabel);
            this.infoPanel.Controls.Add(this.userIDLabel1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 488);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(618, 33);
            this.infoPanel.TabIndex = 3;
            // 
            // sysTimeLabel1
            // 
            this.sysTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "SysTime", true));
            this.sysTimeLabel1.Location = new System.Drawing.Point(501, 10);
            this.sysTimeLabel1.Name = "sysTimeLabel1";
            this.sysTimeLabel1.Size = new System.Drawing.Size(100, 13);
            this.sysTimeLabel1.TabIndex = 7;
            this.sysTimeLabel1.Text = "label1";
            // 
            // sysDateLabel1
            // 
            this.sysDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "SysDate", true));
            this.sysDateLabel1.Location = new System.Drawing.Point(348, 10);
            this.sysDateLabel1.Name = "sysDateLabel1";
            this.sysDateLabel1.Size = new System.Drawing.Size(100, 13);
            this.sysDateLabel1.TabIndex = 5;
            this.sysDateLabel1.Text = "label1";
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UserName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(195, 10);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 13);
            this.userNameLabel1.TabIndex = 3;
            this.userNameLabel1.Text = "label1";
            // 
            // userIDLabel1
            // 
            this.userIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UserID", true));
            this.userIDLabel1.Location = new System.Drawing.Point(60, 10);
            this.userIDLabel1.Name = "userIDLabel1";
            this.userIDLabel1.Size = new System.Drawing.Size(72, 13);
            this.userIDLabel1.TabIndex = 1;
            this.userIDLabel1.Text = "label1";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoginFrom_lsn.UsersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(7, 261);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(595, 205);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn5.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SysDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "SysDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SysTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "SysTime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn10.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 521);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductList";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.menuPanel.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Panel infoPanel;
        private Users users;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private UsersTableAdapters.ProductsTableAdapter productsTableAdapter;
        private UsersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox uOMTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label sysTimeLabel1;
        private System.Windows.Forms.Label sysDateLabel1;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Label userIDLabel1;
    }
}