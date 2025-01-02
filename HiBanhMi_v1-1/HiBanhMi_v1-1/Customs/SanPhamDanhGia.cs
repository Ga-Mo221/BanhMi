using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luotdanhgiasanpham.chinh
{
    public partial class SanPhamDanhGia : UserControl
    {

        public SanPhamDanhGia()
        {
            InitializeComponent();
        }

        public Color BACKGROUND
        {
            get { return pn_background.BackColor; }
            set { pn_background.BackColor = value; Invalidate(); }
        }
        public Image ANHSANPHAM
        {
            get { return pn_anhsp.BackgroundImage; }
            set { pn_anhsp.BackgroundImage = value; Invalidate(); }
        }
        public Image ICONDANHGIA1
        {
            get { return pic_1sao.Image; }
            set { pic_1sao.Image = value; Invalidate(); }
        }
        public Image ICONDANHGIA2
        {
            get { return pic_2sao.Image; }
            set { pic_2sao.Image = value; Invalidate(); }
        }
        public Image ICONDANHGIA3
        {
            get { return pic_3sao.Image; }
            set { pic_3sao.Image = value; Invalidate(); }
        }
        public Image ICONDANHGIA4
        {
            get { return pic_4sao.Image; }
            set { pic_4sao.Image = value; Invalidate(); }
        }
        public Image ICONDANHGIA5
        {
            get { return pic_5sao.Image; }
            set { pic_5sao.Image = value; Invalidate(); }
        }

        
        public void UpdateDanhgia(int danhgia)
        {
            switch (danhgia)
            {
                case 0:
                    {
                        pic_1sao.Visible = false;
                        pic_2sao.Visible = false;
                        pic_3sao.Visible = false;
                        pic_4sao.Visible = false;
                        pic_5sao.Visible = false;
                        break;
                    }
                case 1:
                    {
                        pic_1sao.Visible = true;
                        pic_2sao.Visible = false;
                        pic_3sao.Visible = false;
                        pic_4sao.Visible = false;
                        pic_5sao.Visible = false;
                        break;
                    }
                case 2:
                    {
                        pic_1sao.Visible = true;
                        pic_2sao.Visible = true;
                        pic_3sao.Visible = false;
                        pic_4sao.Visible = false;
                        pic_5sao.Visible = false;
                        break;
                    }
                case 3:
                    {
                        pic_1sao.Visible = true;
                        pic_2sao.Visible = true;
                        pic_3sao.Visible = true;
                        pic_4sao.Visible = false;
                        pic_5sao.Visible = false;
                        break;
                    }
                case 4:
                    {
                        pic_1sao.Visible = true;
                        pic_2sao.Visible = true;
                        pic_3sao.Visible = true;
                        pic_4sao.Visible = true;
                        pic_5sao.Visible = false;
                        break;
                    }
                case 5:
                    {
                        pic_1sao.Enabled = true;
                        pic_2sao.Enabled = true;
                        pic_3sao.Enabled = true;
                        pic_4sao.Enabled = true;
                        pic_5sao.Enabled = true;
                        break;
                    }
            }
        }

        public string TENSANPHAM
        {
            get { return lb_tensp.Text; }
            set { lb_tensp.Text = value; Invalidate(); }
        }
    }
}
