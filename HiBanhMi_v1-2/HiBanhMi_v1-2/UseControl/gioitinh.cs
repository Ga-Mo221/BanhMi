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
    public partial class gioitinh : UserControl
    {
        public string color;
        public gioitinh()
        {
            InitializeComponent();
            color = "#ec6083";
            lb_Title.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lb_nam.ForeColor = Color.Black;
            lb_nu.ForeColor = Color.Black;
            lb_khac.ForeColor = Color.Black;
        }


        public string AA_mauchon
        {
            get => color; set => color = value;
        }
        public string AA_Title
        {
            get => lb_Title.Text;
            set { lb_Title.Text = value; Invalidate(); }
        }
        public string AA_gioitinh
        {
            get => label3.Text;
            set { label3.Text = value; Invalidate(); }
        }
        public Color AA_bgrcolor
        {
            get => this.BackColor;
            set { this.BackColor = value; Invalidate(); }
        }
        public string AA_nam
        {
            get => lb_nam.Text;
            set { lb_nam.Text = value; Invalidate(); }
        }
        public string AA_nu
        {
            get => lb_nu.Text;
            set { lb_nu.Text = value; Invalidate(); }
        }
        public string AA_khac
        {
            get => lb_khac.Text;
            set { lb_khac.Text = value; Invalidate(); }
        }



        private void lb_nu_Click(object sender, EventArgs e)
        {
            label3.Text = lb_nu.Text;
            lb_nu.BackColor = ColorTranslator.FromHtml(color);
            tglen.Start();
        }

        private void lb_nam_Click(object sender, EventArgs e)
        {
            label3.Text = lb_nam.Text;
            lb_nam.BackColor = ColorTranslator.FromHtml(color);
            tglen.Start();
        }

        private void lb_khac_Click(object sender, EventArgs e)
        {
            label3.Text = lb_khac.Text;
            lb_khac.BackColor = ColorTranslator.FromHtml(color);
            tglen.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(Height <= 50) tgxuong.Start();
            else if (Height >= 125) tglen.Start();
        }

        private void tgxuong_Tick(object sender, EventArgs e)
        {
            Height += 5;
            if (Height >= 125) tgxuong.Stop();
        }

        private void tglen_Tick(object sender, EventArgs e)
        {
            Height -= 5;
            if (Height <= 50) tglen.Stop();
        }
    }
}
