using IgoraDemo.CustomControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace IgoraDemo.Forms
{
    public partial class CartForm : ParentForm
    {
        public static ObservableCollection<services_> cartOrders = new ObservableCollection<services_>();

        private int disc = -1;
        private int ClientId = -1;

        public CartForm(int clientId, int disc)
        {
            ClientId = clientId;

            InitializeComponent();
            this.disc = disc;
            cartOrders = MainForm.cartOrders;
            cartOrders.CollectionChanged += OnCollectionChanged;
            UpdateData();
        }

        private void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var a = (MainForm)this.Owner;
            a.CheckCollection();
            UpdateData();
        }

        private void UpdateData()
        {
            var count = cartOrders.Sum(s => s.cost);
            InfoLabel.Text = "Общая скидка - " + this.disc + "; Общая сумма корзины - " + (int)count + ";";

            flowLayoutPanel1.Controls.Clear();
            List<services_> services = MainForm.cartOrders.OrderBy(s => s.service).ToList();

            foreach (services_ service in services)
            {
                flowLayoutPanel1.Controls.Add(new CartProductControl(service, disc));
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderCart_Click(object sender, EventArgs e)
        {
            if (cartOrders.Count <= 0)
            {
                MessageBox.Show("Корзина пуста! Заказ не оформить", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            orders_ newOrder = new orders_();
            newOrder.order_number = Program.context.orders_.Max(o => o.order_number) + 1;

            var time = DateTime.Now;
            newOrder.create_time = time;
            newOrder.order_time = time;

            if (ClientId != -1)
            {
                var client = Program.context.clients_.FirstOrDefault(c => c.id_client == ClientId);

                if (client == null)
                {
                    MessageBox.Show("Пользователь не был найден! Заказ будет от лица guest", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    newOrder.id_client = client.id_client;
                }
            }
            else
            {
                var guestClient = Program.context.clients_.FirstOrDefault(c => c.fio == "guest");
                if (guestClient == null)
                {
                    MessageBox.Show("Пользователь guest не был найден!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                newOrder.id_client = guestClient.id_client;
            }

            newOrder.status_id = 1;
            newOrder.session_minutes = 60;

            foreach (var order in cartOrders)
            {
                newOrder.code = order.code_service + "/" + time.ToString("dd.MM.yyyy");
                newOrder.id_service = order.id_service;

                Program.context.orders_.Add(newOrder);
                Program.context.SaveChanges();
            }
            
            MessageBox.Show("Заказ был оформлен! Осталось подождать подтверждения!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cartOrders.Clear();
            MainForm.cartOrders.Clear();
            this.Close();
        }
    }
}
