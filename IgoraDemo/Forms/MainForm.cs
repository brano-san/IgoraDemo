using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IgoraDemo.CustomControls;
using IgoraDemo.Forms;

namespace IgoraDemo
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateFlowPanel();
        }

        private void UpdateFlowPanel()
        {
            List<services_> services = Program.context.services_.OrderBy(s => s.service).ToList();

            foreach (services_ service in services) 
            {
                flowLayoutPanel1.Controls.Add(new ProductControl(service));
            }
        }
    }
}
