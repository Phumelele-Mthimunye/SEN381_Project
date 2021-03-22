using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions_V1._0._0.BusinessLogic;

namespace PremierServiceSolutions_V1._0._0.PresentationLayer.Service
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Demo demo = new Demo();
            // you can not have any form of logic
            label1.Text = demo.getData();

            if (true)
            {
                // bind to this object1
            }
            else
            {
                // bind to this object2
            }

        }
    }
}
