using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.UseControl
{
    public partial class itemingiohang : UserControl
    {
        public event EventHandler xoa;
        public event EventHandler tang;
        public event EventHandler giam;
        public string masp;
        public itemingiohang()
        {
            InitializeComponent();

            lb_ten.ForeColor = Color.Black;
            lb_gia.ForeColor = Color.Black;
            lb_pt.ForeColor = Color.Black;
            lb_sale.ForeColor = Color.Black;
            lb_soluong.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lb_sale.Visible = false;
            lb_pt.Visible = false;
            pictureBox2.Enabled = false;
        }

        public string AA_masp
        {
            get => masp; set => masp = value;
        }
        public string AA_ten
        {
            get { return lb_ten.Text; }
            set { lb_ten.Text = value; Invalidate(); }
        }
        public string AA_gia
        {
            get { return lb_gia.Text; }
            set { lb_gia.Text = value; Invalidate(); }
        }
        public string AA_sale
        {
            get { return lb_sale.Text; }
            set { lb_sale.Text = value; Invalidate(); }
        }
        public string AA_soluong
        {
            get { return lb_soluong.Text; }
            set { lb_soluong.Text = value; Invalidate(); }
        }


        public void checkgiamgia()
        {
            if (int.Parse(lb_sale.Text) > 0)
            {
                lb_gia.Visible = true;
                lb_pt.Visible = true;  
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            xoa?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(lb_soluong?.Text);
            if (sl < 5)
                sl++;

            lb_soluong.Text = sl.ToString();
            if (sl == 5) pictureBox3.Enabled = false;
            else pictureBox3.Enabled = true;
            if (sl > 1) pictureBox2.Enabled = true;
            tang?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(lb_soluong?.Text);
            if (sl <= 2) pictureBox2.Enabled = false;
            else pictureBox2.Enabled = true;
            if (sl > 1)
                sl--;
            
            lb_soluong.Text = sl.ToString();
            giam?.Invoke(this, EventArgs.Empty);
        }
    }
}
