using DAL.EntityFramework;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_Менеджера_гостиницы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            var login = Login.Text;
            var password = Password.Text;
            var context = new ApplicationDbContext();
            var encryptedPassword = context.Actors
                .Where(e => e.Login == login)
                .Select(e => e.Password)
                .SingleOrDefault();
            if (encryptedPassword != null)
            {
                var verified = EncryptionService.Verify(password, encryptedPassword);
                if (verified)
                {
                    //var identity = IdentityService.ClaimIdentity();
                    //var config = GetFormAccessibilityConfig(identity);
                    //Запрос в базу какие права, и передавать из в вторую форму, при инициализации просто прописывать, какие из 
                    // лэйблов или чего не будет

                    Form2 f = new Form2();
                    f.Show();
                    return;
                }
                MessageBox.Show("Wrong Password");
                return;
            }
            MessageBox.Show("Wrong Login");
        }

        private object GetFormAccessibilityConfig(object identity)
        {
            throw new NotImplementedException();
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
