using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Input;
using static GridRoutines.GridGetItem;

namespace LoginFrom_lsn
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.users);

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.users._Users);

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.CurrID = GetLongRef(usersDataGridView,"ID");
            userRegister.ShowDialog();
            userRegister.Dispose();
            this.usersTableAdapter.Fill(this.users._Users);
        }
    }
}
