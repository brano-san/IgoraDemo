using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IgoraDemo.CustomControls;
using IgoraDemo.Forms;

namespace IgoraDemo
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateFlowPanel();
        }

        private void UpdateFlowPanel()
        {
            List<services_> services = Program.context.services_.OrderBy(s => s.service).ToList();

            foreach (services_ service in services) 
            {
                flowLayoutPanel1.Controls.Add(new ProductControl(service));
            }
        }

        private void authBtn_Click(object sender, System.EventArgs e)
        {
            var authForm = new AuthForm();
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                switch (authForm.Type) 
                {
                    case "client":
                        authLabel.Text = $"Вы авторизовались как клиент: {authForm.UserName}";
                    break;
                    case "manager":
                        authLabel.Text = $"Вы авторизовались как менеджер: {authForm.UserName}";
                        break;
                    case "admin":
                        authLabel.Text = $"Вы авторизовались как администратор: {authForm.UserName}";
                        adminBtn.Visible = true;
                        adminBtn.Enabled = true;
                        var adminForm = new AdminMainForm();
                        adminForm.Owner = this;
                        this.Hide();
                        adminForm.ShowDialog();
                        break;
                    default: break;
                }
                this.authLabel.Visible = true;
                authBtn.Visible = false;
                authBtn.Enabled = false;
            }
        }

        private void adminBtn_Click(object sender, System.EventArgs e)
        {
            var adminForm = new AdminMainForm();
            adminForm.Owner = this;
            this.Hide();
            adminForm.ShowDialog();
        }
    }
}
