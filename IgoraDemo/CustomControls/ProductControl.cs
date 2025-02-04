using System.Windows.Forms;

namespace IgoraDemo.CustomControls
{
    public partial class ProductControl : UserControl
    {
        private services_ _service;

        public ProductControl(services_ service)
        {
            InitializeComponent();
            _service = service;
            UpdateLabelsText();
        }

        private void UpdateLabelsText()
        {
            nameLabel.Text = _service.service.ToString();
            descLabel.Text = _service.code_service.ToString();
            costLabel.Text = _service.cost.ToString();
        }
    }
}
