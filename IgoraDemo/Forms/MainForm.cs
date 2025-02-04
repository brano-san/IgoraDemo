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
                    case "user":
                        authLabel.Text = $"Вы авторизовались как пользователь: {authForm.UserName}";
                    break;
                    case "manager":
                        authLabel.Text = $"Вы авторизовались как менеджер: {authForm.UserName}";
                        break;
                    case "admin":
                        authLabel.Text = $"Вы авторизовались как администратор: {authForm.UserName}";
                        break;
                    default: break;
                }
                this.authLabel.Visible = true;
            }
        }
    }
}
