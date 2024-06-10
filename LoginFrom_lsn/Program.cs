using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrom_lsn
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm(); //Is this "bad"???
            loginForm.ShowDialog();
            if(loginForm.IsPasswordCorrect )
            {
                MainForm mainForm = new MainForm();
                mainForm.userLabel.Text = loginForm.usernameComboBox.Text;
                mainForm.userPictureBox.Image = loginForm.userPictureBox.Image;
                loginForm.Dispose();
                //Alternative is put it in the MainForm load
                Application.Run(mainForm);
                //Application.Run(new ProductList());
            }
            else
            {
                loginForm.Dispose();
            }
        }
    }
}
