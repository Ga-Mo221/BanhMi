using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Forms
{
    public partial class ThucDonform : Form
    {
        public ThucDonform()
        {
            InitializeComponent();
            item1.THEMckick += Item1_THEMckick;
        }

        private void Item1_THEMckick(object sender, EventArgs e)
        {
        }
    }
}
