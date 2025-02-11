using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IgoraDemo.Models;

namespace IgoraDemo.Forms
{
    public partial class ClientHistory : ParentForm
    {
        private clients_ client;

        private List<OrdersRow> ordersRows = new List<OrdersRow>();

        public ClientHistory(clients_ client)
        {
            InitializeComponent();
            this.client = client;
            label1.Text = "История клиента: " + client.fio;
            this.Text = "История клиента: " + client.fio;
        }

        private void ClientHistory_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            ordersRows.Clear();
            var orders = Program.context.orders_.Where(o => o.id_client == client.id_client)
                .GroupBy(or => or.order_number).ToList();
           
            foreach (var o in orders)
            {
                OrdersRow ordersRow = new OrdersRow();
                var statusId = o.First().status_id;
                var status = Program.context.statuses_.FirstOrDefault(s => s.id_status == statusId);

                ordersRow.OrderNumber = o.First().order_number;
                ordersRow.Fio = client.fio;
                ordersRow.Date = o.First().order_time;
                ordersRow.Sum = o.Sum(order => order.services_.cost);
                ordersRow.rating = client.rating;
                ordersRow.status = status.status;

                ordersRows.Add(ordersRow);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordersRows;
            dataGridView1.Columns[0].Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void ClientHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать заказ для отмены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selService = dataGridView1.SelectedRows[0];
            if (selService == null)
            {
                MessageBox.Show("Необходимо выбрать заказ для отмены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var order_number = (int)selService.Cells[0].Value;
            var orders = Program.context.orders_.Where(o => o.order_number == order_number).ToList();

            foreach (var o in orders)
            {
                if (o.status_id == 3)
                {
                    MessageBox.Show("Заказ уже завершён!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (o.status_id == 2)
                {
                    MessageBox.Show("За заказ уже внесены деньги. Отменить нельзя!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                o.status_id = 4;
                Program.context.SaveChanges();
            }
            UpdateData();
            MessageBox.Show("Заказ был отменен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
