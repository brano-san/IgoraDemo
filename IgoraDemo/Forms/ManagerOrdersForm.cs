﻿using IgoraDemo.Models;
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
    public partial class ManagerOrdersForm : ParentForm
    {
        private List<OrdersRow> ordersRows = new List<OrdersRow>();

        public ManagerOrdersForm()
        {
            InitializeComponent();
            UpdateData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerOrdersForm_Load(object sender, EventArgs e)
        {
        }

        private void UpdateData()
        {
            ordersRows.Clear();
            var orders = Program.context.orders_.GroupBy(or => or.order_number).ToList();


            foreach (var o in orders)
            {
                OrdersRow ordersRow = new OrdersRow();

                var statusId = o.First().status_id;
                var status = Program.context.statuses_.FirstOrDefault(s => s.id_status == statusId);

                ordersRow.OrderNumber = o.First().order_number;
                ordersRow.Fio = o.First().clients_.fio;
                ordersRow.Date = o.First().order_time;
                ordersRow.Sum = o.Sum(order => order.services_.cost);
                ordersRow.rating = o.First().clients_.rating;
                ordersRow.status = status.status;

                if (ordersRow.Fio.ToLower().Contains(SearchTb.Text.ToLower()))
                {
                    ordersRows.Add(ordersRow);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordersRows;
            dataGridView1.Columns["orderNumber"].Visible = false;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать строку для подтверждения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow == null)
            {
                MessageBox.Show("Необходимо выбрать строку для подтверждения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)selectedRow.Cells["orderNumber"].Value;

            var editOrders = Program.context.orders_.Where(o => o.order_number == id).ToList();
            foreach (var order in editOrders)
            {
                if (order.status_id == 1)
                {
                    order.status_id = 2;
                }
                else if (order.status_id == 2) 
                {
                    order.status_id = 3;
                }
                else
                {
                    MessageBox.Show("Статус заказа \"Закрыт\". Изменить нельзя", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.context.SaveChanges();
            }

            UpdateData();
            MessageBox.Show("Статус был обновлён!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать строку для подтверждения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow == null)
            {
                MessageBox.Show("Необходимо выбрать строку для подтверждения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)selectedRow.Cells["orderNumber"].Value;

            var ordersEditForm = new ManagerEditOrderForm(id);
            ordersEditForm.Owner = this;
            ordersEditForm.ShowDialog();

            UpdateData();
        }
    }
}
