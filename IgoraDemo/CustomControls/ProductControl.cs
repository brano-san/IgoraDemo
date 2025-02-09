using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace IgoraDemo.CustomControls
{
    public partial class ProductControl : UserControl
    {
        private services_ _service;

        public ProductControl(services_ service, int disc = -1)
        {
            InitializeComponent();
            _service = service;
            UpdateLabelsText(disc);
        }

        private void UpdateLabelsText(int disc)
        {
            nameLabel.Text = _service.service.ToString();
            descLabel.Text = _service.code_service.ToString();
            costLabel.Text = _service.cost.ToString();

            if (disc >= 0)
            {
                label6.Visible = true;
                costDiscLabel.Text = Convert.ToString(_service.cost - (_service.cost * disc / 100));
                costDiscLabel.Visible = true;
                label7.Visible = true;
                discount.Text = Convert.ToString(disc) + '%';
                discount.Visible = true;
            }
        }
    }
}
