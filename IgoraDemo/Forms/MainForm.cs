using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IgoraDemo.CustomControls;
using IgoraDemo.Forms;
using IgoraDemo.Services;

namespace IgoraDemo
{
    public partial class MainForm : ParentForm
    {
        private int clientId = -1;

        public static ObservableCollection<services_> cartOrders = new ObservableCollection<services_>();

        public MainForm()
        {
            InitializeComponent();
            UpdateFlowPanel();
            cartOrders.CollectionChanged += onCollectionChanged;
        }

        private void onCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CheckCollection();
        }

        public void CheckCollection()
        {
            if (cartOrders.Count > 0)
            {
                CartBtn.Visible = true;
                CartBtn.Enabled = true;
            }
            else
            {
                CartBtn.Visible = false;
                CartBtn.Enabled = false;
            }
        }

        private void UpdateFlowPanel(int disc = -1)
        {
            flowLayoutPanel1.Controls.Clear();
            List<services_> services = Program.context.services_.OrderBy(s => s.service).ToList();

            foreach (services_ service in services) 
            {
                flowLayoutPanel1.Controls.Add(new ProductControl(service, disc));
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

                        var count = Program.context.orders_.Where(o => o.id_client == authForm.Id).Sum(o => o.services_.cost) ?? 0;
                        var discount = DiscountCalculation.calculateDiscount((int)count);
                        UpdateFlowPanel(discount);
                        HistoryBtn.Visible = true;
                        HistoryBtn.Enabled = true;
                        clientId = authForm.Id;
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

        private void HistoryBtn_Click(object sender, System.EventArgs e)
        {
            var client = Program.context.clients_.FirstOrDefault(c => c.id_client == clientId);

            if (client == null)
            {
                return;
            }

            var historyForm = new ClientHistory(client);
            historyForm.Owner = this;
            historyForm.ShowDialog();
        }

        private void CartBtn_Click(object sender, System.EventArgs e)
        {
            var count = Program.context.orders_.Where(o => o.id_client == this.clientId).Sum(o => o.services_.cost) ?? 0;
            var discount = DiscountCalculation.calculateDiscount((int)count);

            var cartForm = new CartForm(clientId, discount);
            cartForm.Owner = this;
            cartForm.ShowDialog();
            CheckCollection();
        }
    }
}
