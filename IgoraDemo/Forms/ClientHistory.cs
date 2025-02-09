using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IgoraDemo.Models;

namespace IgoraDemo.Forms
{
    public partial class ClientHistory : Form
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
            var orders = Program.context.orders_.Where(o => o.id_client == client.id_client)
                .GroupBy(or => or.order_number).ToList();

            OrdersRow ordersRow = new OrdersRow();
            foreach (var o in orders)
            {
                var statusId = o.First().status_id;
                var status = Program.context.statuses_.FirstOrDefault(s => s.id_status == statusId);

                ordersRow.Fio = client.fio;
                ordersRow.Date = o.First().order_time;
                ordersRow.Sum = o.Sum(order => order.services_.cost);
                ordersRow.rating = client.rating;
                ordersRow.status = status.status;

                ordersRows.Add(ordersRow);
            }

            dataGridView1.DataSource = ordersRows;
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
    }
}
