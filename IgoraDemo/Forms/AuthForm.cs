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

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            var user = Program.context.worker_.FirstOrDefault(worker_=> worker_.login == loginTB.Text);
            if (user == null)
            {
                MessageBox.Show("Неверный логин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
