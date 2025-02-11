using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgoraDemo.Forms
{
    public partial class AuthForm : ParentForm
    {
        public string Type;
        public string UserName;
        public int Id;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            var user = Program.context.worker_.FirstOrDefault(worker_=> worker_.login == loginTB.Text);
            if (user == null)
            {
                var client = Program.context.clients_.FirstOrDefault(c => c.email == loginTB.Text);
                if (client == null)
                {
                    MessageBox.Show("Неверный логин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (client.password != PasswordTB.Text)
                {
                    MessageBox.Show("Неверный пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Type = "client";
                this.UserName = client.fio.ToString();
                this.Id = client.id_client;

                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (user.pass != PasswordTB.Text)
            {
                MessageBox.Show("Неверный пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var role = Program.context.posts_.FirstOrDefault(p => p.id_post == user.id_post);
            this.Type = role.post.ToString();
            this.UserName = user.fio.ToString();
            this.Id = user.id_worker;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = !PasswordTB.UseSystemPasswordChar;
        }
    }
}
