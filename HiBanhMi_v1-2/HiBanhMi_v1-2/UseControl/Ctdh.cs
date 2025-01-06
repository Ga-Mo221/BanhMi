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
    public partial class Ctdh : UserControl
    {
        public event EventHandler danhgia;
        public Ctdh()
        {
            InitializeComponent();

            setcolor();
            check();
        }

        private void setcolor()
        {
            lb_ten.ForeColor = Color.Black;
            lb_soluong.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            lb_giagoc.ForeColor = Color.Black;
            lb_giacuoi.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lb_danhgia.ForeColor = Color.Black;
        }
        public Image AA_anh
        {
            get { return pic_anh.Image; }
            set { pic_anh.Image = value; Invalidate(); }
        }
        public string AA_ten
        {
            get { return lb_ten.Text; }
            set { lb_ten.Text = value; Invalidate(); }
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
        public string AA_danhgia
        {
            get { return lb_danhgia.Text; }
            set { lb_danhgia.Text = value; Invalidate(); }
        }




        private void check()
        {
            if (AA_giacuoi == AA_giagoc)
            {
                lb_giagoc.Visible = false;
                label2.Visible = false;
            }
        }






        private void lb_danhgia_Click(object sender, EventArgs e)
        {
            danhgia?.Invoke(this, EventArgs.Empty);
        }

        private void pic_danhgia_Click(object sender, EventArgs e)
        {
            danhgia?.Invoke(this, EventArgs.Empty);
        }
    }
}
