using HiBanhMi_v1_2.Codes;
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
    public partial class YeuThichform : Form
    {
        loaditem loadit = new loaditem();
        public YeuThichform()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);

            loadit.Load(fpn_yeuthich);




            // set ngon ngu
            setngonngu();
            // set color
            setcolor();
        }


        private void setngonngu()
        {
            label1.Text = NN.nn[67];
        }
        private void setcolor()
        {
            label1.ForeColor = Color.Black;
            BackColor = ColorTranslator.FromHtml(THEME.t[0]);
        }
    }
}
