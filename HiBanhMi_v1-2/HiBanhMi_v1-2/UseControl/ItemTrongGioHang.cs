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
    public partial class ItemTrongGioHang : UserControl
    {
        private string masp;
        public event EventHandler xoa;
        public event EventHandler tang;
        public event EventHandler giam;

        public ItemTrongGioHang()
        {
            InitializeComponent();

            setcolor();

            pictureBox1.Enabled = false;
        }
        private void setcolor()
        {
            lb_ten.ForeColor = Color.Black;
            lb_giamgia.ForeColor = Color.Black;
            lb_giagoc.ForeColor = Color.Black;
            lb_giacuoi.ForeColor = Color.Black;
            lb_soluong.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;

            label4.BackColor = Color.Black;
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
        public string AA_sale
        {
            get { return lb_giamgia.Text; }
            set { lb_giamgia.Text = value; Invalidate(); }
        }
        public string AA_soluong
        {
            get { return lb_soluong.Text; }
            set { lb_soluong.Text = value; Invalidate(); }
        }
        public string AA_giagoc
        {
            get { return lb_giagoc.Text; }
            set { lb_giagoc.Text = value; Invalidate(); }
        }
        public string AA_giacuoi
        {
            get { return lb_giacuoi.Text; }
            set { lb_giacuoi.Text = value; Invalidate(); }
        }








        private void pic_xoa_Click(object sender, EventArgs e)
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
            if (sl > 1) pictureBox1.Enabled = true;
            tang?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(lb_soluong?.Text);
            if (sl <= 2) pictureBox1.Enabled = false;
            else pictureBox1.Enabled = true;
            if (sl > 1)
                sl--;

            lb_soluong.Text = sl.ToString();
            giam?.Invoke(this, EventArgs.Empty);
        }
    }
}
