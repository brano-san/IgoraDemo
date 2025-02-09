using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgoraDemo.Forms
{
    public partial class AdminAddEditForm : ParentForm
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

        private bool ValidateData()
        {
            string fio = serviceTextBox.Text;
            if (string.IsNullOrEmpty(fio) || !Regex.IsMatch(fio, @"^[А-ЯЁЙа-яёйA-Za-z0-9][а-яёйa-z0-9\s]+$"))
            {
                MessageBox.Show("Название услуги требует более двух символов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string code = code_serviceTextBox.Text;
            if (string.IsNullOrEmpty(code) || !Regex.IsMatch(code, @"^[A-Za-z0-9][A-Za-z0-9]+$"))
            {
                MessageBox.Show("Артикул услуги требует более двух символов. Только латинские буквы и цифры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string cost = costTextBox.Text;
            if (string.IsNullOrEmpty(cost) || !Regex.IsMatch(cost, @"^[0-9]+$"))
            {
                MessageBox.Show("Стоимость может состоять только из цифр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            var res = MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
            {
                return;
            }

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
