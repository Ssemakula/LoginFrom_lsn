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
    public partial class UserRegister : Form
    {
        private long _currID;
        private bool isDeleting = false;

        public UserRegister()
        {
            InitializeComponent();
        }

        public long CurrID { 
            get { return _currID; } 
            set { _currID = value; }
        }


        private void UserRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users._Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillBy_ID(this.users._Users, CurrID);
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
            this.usersBindingSource.AddNew();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current == null)
            {
                Notify("No record to edit");
                return;
            }
            ButtonsShow(false);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current == null)
            {
                Notify("No record to delete");
                return;
            }
            ButtonsShow(false);
            this.infoGroupBox.Enabled=false;
            this.usersBindingSource.RemoveCurrent();
            isDeleting = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            this.usersBindingSource.EndEdit();
            if (this.usersTableAdapter.Update(this.users._Users) > 0) 
            {
                if (isDeleting)
                {
                    Notify("Record successfully deleted", "Delete");
                    isDeleting = false;
                }
                else
                {
                    if(IsTrue(iDTextBox.Text))
                    {
                        CurrID = GetPosition();
                    }
                    this.usersTableAdapter.FillBy_ID(this.users._Users, CurrID);
                    Notify("Record successfully saved", "Save");
                }
            }
            else
            {
                MessageBox.Show("Failed to update database");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ButtonsShow();
            this.usersBindingSource.CancelEdit();
            this.users._Users.RejectChanges();
            this.isDeleting = false;
            Notify("Changes cancelled");
        }

        private void UserImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files |*.jpg;*.png;*.tif;*.tiff;*.jepd";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string imageFIle;
                imageFIle = dlg.FileName;
                this.userPictureBox.Image = Image.FromFile(imageFIle);
            }
        }

        //Position thing
        private long GetPosition()
        {
            long currRecord;
            if(!IsTrue(iDTextBox.Text)) //Empty box
            {
                currRecord = 0;
            }
            Int64.TryParse(this.iDTextBox.Text, out currRecord);
            if(currRecord < 1) {
                currRecord = 0;
            }
            return currRecord;
        }

    }
}
