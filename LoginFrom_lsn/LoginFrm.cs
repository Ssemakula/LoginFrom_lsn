using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage.Search;

namespace LoginFrom_lsn
{
    public partial class LoginForm : Form
    {
        private bool isPasswordCorrect  = false;

        public bool IsPasswordCorrect
        {
            get { return isPasswordCorrect; }
            set { isPasswordCorrect = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users._Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users._Users);
            passwordTextBox.Focus(); //Also check this

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Password check routine. Ignoring the one used by the lesson
            //as I already have a good working password login routine
            // For now just login if not blank
            if(!String.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                //Close this with success
                IsPasswordCorrect = true;
                long _ID = (long) usernameComboBox.SelectedValue; //Combo box not picking????
                LoginFrom_lsn.Properties.Settings.Default.UserID = _ID;
                LoginFrom_lsn.Properties.Settings.Default.UserName = this.usernameComboBox.Text;
                this.Close();
            }
            else
            {
                isPasswordCorrect = false;
                //Return and wait
            }
        }
    }
}
