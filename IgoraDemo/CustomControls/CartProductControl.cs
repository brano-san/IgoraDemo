using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using IgoraDemo.Forms;

namespace IgoraDemo.CustomControls
{
    public partial class CartProductControl : UserControl
    {
        private services_ service;
        public CartProductControl(services_ service, int disc)
        {
            InitializeComponent();
            this.service = service;
            UpdateLabelsText(disc);
        }

        private void UpdateLabelsText(int disc)
        {
            nameLabel.Text = service.service.ToString();
            descLabel.Text = service.code_service.ToString();
            costLabel.Text = service.cost.ToString();
            label2.Text = service.available;

            if (disc >= 0)
            {
                label6.Visible = true;
                costDiscLabel.Text = Convert.ToString(service.cost - (service.cost * disc / 100));
                costDiscLabel.Visible = true;
                label7.Visible = true;
                discount.Text = Convert.ToString(disc) + '%';
                discount.Visible = true;
            }
        }

        private void добавитьВКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartForm.cartOrders.Remove(service);
        }
    }
}
