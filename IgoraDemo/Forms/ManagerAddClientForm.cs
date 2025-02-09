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
    public partial class ManagerAddClientForm : ParentForm
    {
        public ManagerAddClientForm()
        {
            InitializeComponent();
        }

        public bool ValidateClientData()
        {
            // Валидация ФИО
            string fio = fioTextBox.Text;
            if (string.IsNullOrEmpty(fio) || !Regex.IsMatch(fio, @"^[А-ЯЁЙа-яёйA-Za-z][а-яёйa-z]*\s[А-ЯЁЙа-яёйA-Za-z][а-яёйa-z]*\s[А-ЯЁЙа-яёйA-Za-z][а-яёйa-z]*$"))
            {
                MessageBox.Show("ФИО должно быть в формате 'Фамилия Имя Отчество'!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация кода
            if (!double.TryParse(codeTextBox.Text, out double code) || code <= 0)
            {
                MessageBox.Show("Код должен быть положительным числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация паспорта
            string pasport = pasportTextBox.Text.Trim();
            if (string.IsNullOrEmpty(pasport) || !Regex.IsMatch(pasport, @"^Серия\s\d{4}\sНомер\s\d{6}$"))
            {
                MessageBox.Show("Паспорт должен быть в формате 'Серия XXXX Номер XXXXXX'!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация даты рождения
            DateTime bornDate = born_dateDateTimePicker.Value;
            if (bornDate >= DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация адреса
            string address = addressTextBox.Text.Trim();
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Адрес не может быть пустым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация email
            string email = emailTextBox.Text.Trim();
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация пароля
            string password = passwordTextBox.Text.Trim();
            if (string.IsNullOrEmpty(password) || password.Length < 8 || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов, включая заглавные и строчные буквы, а также цифры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Валидация рейтинга
            if (!int.TryParse(ratingTextBox.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Рейтинг может быть от 1 до 5!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateClientData())
            {
                return;
            }

            clients_ client = new clients_();
            client.fio = fioTextBox.Text;
            client.code = Convert.ToDouble(codeTextBox.Text);
            client.pasport = pasportTextBox.Text;
            client.born_date = born_dateDateTimePicker.Value;
            client.address = addressTextBox.Text;
            client.email = emailTextBox.Text;
            client.password = passwordTextBox.Text;
            client.rating = Convert.ToInt32(ratingTextBox.Text);

            Program.context.clients_.Add(client);
            Program.context.SaveChanges();

            MessageBox.Show("Клиент был успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
