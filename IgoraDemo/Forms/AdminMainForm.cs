using System;
using System.Linq;
using System.Windows.Forms;

namespace IgoraDemo.Forms
{
    public partial class AdminMainForm : ParentForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selService = dataGridView1.SelectedRows[0];
            if (selService == null)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)selService.Cells[0].Value;

            var service = Program.context.services_.FirstOrDefault(s => s.id_service == id);
            if (service == null)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var order = Program.context.orders_.FirstOrDefault(o => o.id_service == service.id_service);
            if (order != null)
            {
                MessageBox.Show("Услуга уже была заказана! Удалить нельзя", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Вы уверены что хотите удалить строку?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Program.context.services_.Remove(service);
                Program.context.SaveChanges();
            }
            this.services_TableAdapter.Fill(this.igoraDataSet._services_);
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.services_TableAdapter.Fill(this.igoraDataSet._services_);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AdminAddEditForm();
            addForm.ShowDialog();

            this.services_TableAdapter.Fill(this.igoraDataSet._services_);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selService = dataGridView1.SelectedRows[0];
            if (selService == null)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)selService.Cells[0].Value;

            var service = Program.context.services_.FirstOrDefault(s => s.id_service == id);
            if (service == null)
            {
                MessageBox.Show("Необходимо выбрать строку для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var addForm = new AdminAddEditForm(service);
            addForm.ShowDialog();

            this.services_TableAdapter.Fill(this.igoraDataSet._services_);
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
