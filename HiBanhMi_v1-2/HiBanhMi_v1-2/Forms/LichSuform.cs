using ArtanComponent;
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
    public partial class LichSuform : Form
    {
        
        DocFile doc = new DocFile();
        loadlichsu load = new loadlichsu();
        public LichSuform()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);


            listdh.dh.Clear();
            doc.lichsudonhang(listdh.dh);

            load.LoadLichsuDonHang(fpn);

            setcolor();
            setngonngu();
        }


        private void setngonngu()
        {
            lb_ten.Text = NN.nn[26];
        }
        private void setcolor()
        {
            BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            lb_ten.ForeColor = Color.Black;
        }
    }
}
