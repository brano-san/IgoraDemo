﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IgoraDemo.CustomControls;
using IgoraDemo.Forms;
using DiscountCalculationLibrary;

namespace IgoraDemo
{
    public partial class MainForm : ParentForm
    {
        private int clientId = -1;

        public static ObservableCollection<services_> cartOrders = new ObservableCollection<services_>();

        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
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

        private void UpdateFlowPanel()
        {
            int discount = 0;
            if (clientId != -1)
            {
                var count = Program.context.orders_.Where(o => o.id_client == clientId).Sum(o => o.services_.cost) ?? 0;
                discount = DiscountCalculation.calculateDiscount((int)count);
            }

            flowLayoutPanel1.Controls.Clear();
            List<services_> services = Program.context.services_.Where(s => s.service.Contains(textBox1.Text)).ToList();

            if (comboBox1.SelectedIndex != null) 
            {
                if (comboBox1.SelectedIndex == 0) 
                {
                    services = services.OrderBy(s => s.service).ToList();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    services = services.OrderBy(s => s.cost).ToList();
                }
                else
                {
                    services = services.OrderByDescending(s => s.cost).ToList();
                }
            }

            foreach (services_ service in services) 
            {
                flowLayoutPanel1.Controls.Add(new ProductControl(service, discount));
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
                        clientId = authForm.Id;
                        
                        UpdateFlowPanel();
                        HistoryBtn.Visible = true;
                        HistoryBtn.Enabled = true;
                        
                    break;
                    case "manager":
                        authLabel.Text = $"Вы авторизовались как менеджер: {authForm.UserName}";
                        ClientsBtn.Visible = true;
                        ClientsBtn.Enabled = true;
                        OrdersBtn.Visible = true;
                        OrdersBtn.Enabled = true;
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
            var count = Program.context.orders_.Where(o => o.id_client == clientId).Sum(o => o.services_.cost) ?? 0;
            var discount = DiscountCalculation.calculateDiscount((int)count);

            var cartForm = new CartForm(clientId, discount);
            cartForm.Owner = this;
            cartForm.ShowDialog();
            CheckCollection();
            UpdateFlowPanel();
        }

        private void OrdersBtn_Click(object sender, System.EventArgs e)
        {
            var ordersForm = new ManagerOrdersForm();
            ordersForm.Owner = this;
            ordersForm.ShowDialog();
        }

        private void ClientsBtn_Click(object sender, System.EventArgs e)
        {
            var clientsForm = new ManagerClientsForm();
            clientsForm.Owner = this;
            clientsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            UpdateFlowPanel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateFlowPanel();
        }
    }
}
