﻿using System;
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
    public partial class ManagerClientsForm : ParentForm
    {
        public ManagerClientsForm()
        {
            InitializeComponent();
        }

        private void ManagerClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._statuses_". При необходимости она может быть перемещена или удалена.
            this.statuses_TableAdapter.Fill(this.igoraDataSet._statuses_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._enter_type_". При необходимости она может быть перемещена или удалена.
            this.enter_type_TableAdapter.Fill(this.igoraDataSet._enter_type_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._clients_". При необходимости она может быть перемещена или удалена.
            this.clients_TableAdapter.Fill(this.igoraDataSet._clients_);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var clientsForm = new ManagerAddClientForm();
            clientsForm.Owner = this;
            clientsForm.ShowDialog();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._statuses_". При необходимости она может быть перемещена или удалена.
            this.statuses_TableAdapter.Fill(this.igoraDataSet._statuses_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._enter_type_". При необходимости она может быть перемещена или удалена.
            this.enter_type_TableAdapter.Fill(this.igoraDataSet._enter_type_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._clients_". При необходимости она может быть перемещена или удалена.
            this.clients_TableAdapter.Fill(this.igoraDataSet._clients_);
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.context.clients_.Where(c => c.fio.Contains(SearchTb.Text)).ToList();
        }

        private void Editbtn_Click(object sender, EventArgs e)
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
            
            var client = Program.context.clients_.FirstOrDefault(c => c.id_client == id);
            if (client == null)
            {
                MessageBox.Show("Некорретный пользователь!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clientsForm = new ManagerAddClientForm(client);
            clientsForm.Owner = this;
            clientsForm.ShowDialog();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._statuses_". При необходимости она может быть перемещена или удалена.
            this.statuses_TableAdapter.Fill(this.igoraDataSet._statuses_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._enter_type_". При необходимости она может быть перемещена или удалена.
            this.enter_type_TableAdapter.Fill(this.igoraDataSet._enter_type_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet._clients_". При необходимости она может быть перемещена или удалена.
            this.clients_TableAdapter.Fill(this.igoraDataSet._clients_);
        }
    }
}
