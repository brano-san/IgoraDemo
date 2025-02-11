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
            comboBox1.SelectedIndex = 0;
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

            UpdateData();
        }

        private void UpdateData()
        {
            var services = Program.context.services_.Where(s => s.service.Contains(textBox1.Text)).ToList();
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

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = services;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AdminAddEditForm();
            addForm.ShowDialog();

            UpdateData();
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

            UpdateData();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
