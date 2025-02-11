using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgoraDemo.Forms
{
    public partial class ManagerEditOrderForm : ParentForm
    {
        private int OrderNumber;

        public ManagerEditOrderForm(int orderNumber)
        {
            InitializeComponent();
            OrderNumber = orderNumber;
            UpdateData();
        }

        private void UpdateData()
        {
            var editOrders = Program.context.orders_.Where(o => o.order_number == OrderNumber).ToList();
            List<orders_> orders = new List<orders_>();

            foreach (var order in editOrders)
            {
                string str = order.code.ToString() + order.clients_.fio.ToString() + order.order_number.ToString() +
                             order.services_.service.ToString()
                             + order.statuses_.status.ToString();


                if (str.ToLower().Contains(SearchTb.Text.ToLower()))
                {
                    orders.Add(order);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerEditOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._clients_". При необходимости она может быть перемещена или удалена.
            this.clients_TableAdapter.Fill(this.igoraDataSet._clients_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._services_". При необходимости она может быть перемещена или удалена.
            this.services_TableAdapter.Fill(this.igoraDataSet._services_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._statuses_". При необходимости она может быть перемещена или удалена.
            this.statuses_TableAdapter.Fill(this.igoraDataSet._statuses_);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Program.context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ManagerEditOrderForm_FormClosing(object sender, FormClosingEventArgs ev)
        {
            var undetachedEntriesCopy = Program.context.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Detached)
                .ToList();
            foreach (var entry in undetachedEntriesCopy)
                entry.State = EntityState.Detached;
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
