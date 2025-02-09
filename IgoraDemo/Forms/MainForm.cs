﻿using System.Collections.Generic;
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
        public MainForm()
        {
            InitializeComponent();
            UpdateFlowPanel();
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
    }
}
