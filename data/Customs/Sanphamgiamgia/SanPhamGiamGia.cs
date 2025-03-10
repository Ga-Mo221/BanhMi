﻿using System.Drawing;
using System.Windows.Forms;

namespace spgiamgia.chinh
{
    public partial class SanPhamGiamGia : UserControl
    {
        public SanPhamGiamGia()
        {
            InitializeComponent();
        }

        public string TENSANPHAM
        {
            get { return lb_Tensp.Text; }
            set { lb_Tensp.Text = value; Invalidate(); }
        }
        public string GIAGIAM
        {
            get { return lb_giamgia.Text; }
            set { lb_giamgia.Text = value; Invalidate(); }
        }
        public string GIAHIENTAI
        {
            get { return lb_gia.Text; }
            set { lb_gia.Text = value; Invalidate(); }
        }

        public Image ANHSANPHAM
        {
            get { return panelCustom2.BackgroundImage; }
            set { panelCustom2.BackgroundImage = value; Invalidate(); }
        }
    }
}
