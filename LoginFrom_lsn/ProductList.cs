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
            try
            {
                productsTableAdapter.Fill(users.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ButtonsShow();
        }

        private void ButtonsShow(bool viewMode = true)
        {
            if (viewMode)
            {
                newButton.Enabled = true;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                exitButton.Enabled = true;
                infoGroupBox.Enabled = false;
            }
            else
            {
                newButton.Enabled = false;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                saveButton.Enabled = true;
                cancelButton.Enabled = true;
                exitButton.Enabled = false;
                infoGroupBox.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ButtonsShow(false);
            productsBindingSource.AddNew();
            LableUpdate();
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
            infoGroupBox.Enabled = false;
            try
            {
                productsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            isDeleting = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            try
            {
                productsBindingSource.EndEdit();
                if (productsTableAdapter.Update(users.Products) > 0)
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LableUpdate();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            try
            {
                productsBindingSource.CancelEdit();
                users.Products.RejectChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            isDeleting = false;
            Notify("Changes cancelled");
        }

        private void LableUpdate()
        {
            userIDLabel1.Text = LoginFrom_lsn.Properties.Settings.Default.UserID.ToString();
            userNameLabel1.Text = LoginFrom_lsn.Properties.Settings.Default.UserName.ToString();
            ///Date and time
            sysDateLabel1.Text = DateTime.Now.ToShortDateString();
            sysTimeLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
