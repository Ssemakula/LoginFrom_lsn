using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotifyMethods.NotifyMessage;
using static LogicMethods.LogicMethods;

namespace LoginFrom_lsn
{
    public partial class ProductList : Form
    {
        private bool isDeleting = false;
        private long _currID;
        public ProductList()
        {
            InitializeComponent();
        }

        public long CurrID
        {
            get { return _currID; }
            set { _currID = value; }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.users.Products);
            ButtonsShow();
        }

        private void ButtonsShow(bool viewMode = true)
        {
            if (viewMode)
            {
                this.newButton.Enabled = true;
                this.editButton.Enabled = true;
                this.deleteButton.Enabled = true;
                this.saveButton.Enabled = false;
                this.cancelButton.Enabled = false;
                this.exitButton.Enabled = true;
                this.infoGroupBox.Enabled = false;
            }
            else
            {
                this.newButton.Enabled = false;
                this.editButton.Enabled = false;
                this.deleteButton.Enabled = false;
                this.saveButton.Enabled = true;
                this.cancelButton.Enabled = true;
                this.exitButton.Enabled = false;
                this.infoGroupBox.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ButtonsShow(false);
            this.productsBindingSource.AddNew();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (productsBindingSource.Current == null)
            {
                Notify("No record to edit");
                return;
            }
            ButtonsShow(false);
            LableUpdate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (productsBindingSource.Current == null)
            {
                Notify("No record to delete");
                return;
            }
            ButtonsShow(false);
            this.infoGroupBox.Enabled = false;
            this.productsBindingSource.RemoveCurrent();
            isDeleting = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            this.productsBindingSource.EndEdit();
            if (this.productsTableAdapter.Update(this.users.Products) > 0)
            {
                if (isDeleting)
                {
                    Notify("Record successfully deleted", "Delete");
                    isDeleting = false;
                }
                else
                {
                    Notify("Record successfully saved", "Save");
                }
            }
            else
            {
                MessageBox.Show("Failed to update database");
            }
            LableUpdate();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            this.productsBindingSource.CancelEdit();
            this.users.Products.RejectChanges();
            this.isDeleting = false;
            Notify("Changes cancelled");
        }

        private void LableUpdate()
        {
            this.userIDLabel1.Text = LoginFrom_lsn.Properties.Settings.Default.UserID.ToString();
            this.userNameLabel1.Text = LoginFrom_lsn.Properties.Settings.Default.UserName.ToString();
            ///Date and time
            this.sysDateLabel1.Text = DateTime.Now.ToShortDateString();
            this.sysTimeLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
