using Entity.Service;
using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            var login = Login.Text;
            var password = Password.Text;
            try
            {
                IdentityService.ClaimIdentity(login, password);
                MainForm f = new MainForm();
                f.Show();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
