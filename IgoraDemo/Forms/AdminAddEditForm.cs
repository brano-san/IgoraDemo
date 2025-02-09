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
    public partial class AdminAddEditForm : Form
    {
        private services_ service;

        public AdminAddEditForm()
        {
            InitializeComponent();
            service = new services_();
            this.Text = "Добавление услуги";
        }

        public AdminAddEditForm(services_ service)
        {
            InitializeComponent();
            this.service = service;
            this.Text = "Редактирование услуги";
            UpdateData();
        }

        private void UpdateData()
        {
            serviceTextBox.Text = service.service;
            code_serviceTextBox.Text = service.code_service;
            costTextBox.Text = Convert.ToString(service.cost);
        }

        private void services_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.services_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);
        }

        private void AdminAddEditForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены что хотите закрыть форму?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            if (this.Text == "Редактирование услуги")
            {
                service.service = serviceTextBox.Text;
                service.code_service = code_serviceTextBox.Text;
                service.cost = Convert.ToDouble(costTextBox.Text);
                Program.context.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            var res = MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var addService = new services_
                {
                    service = serviceTextBox.Text,
                    code_service = code_serviceTextBox.Text,
                    cost = Convert.ToDouble(costTextBox.Text)
                };

                Program.context.services_.Add(addService);
                Program.context.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
