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
    public partial class item : UserControl
    {
        public event EventHandler THEMckick;
        public item()
        {
            InitializeComponent();
            lb_ten.ForeColor = Color.Black;
            lb_daban.ForeColor = Color.Black;
            lb_danhgia.ForeColor = Color.Black;
            lb_giamgia.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;

            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            bt_them.BackgroundImage = Properties.Resources.add;
            pic_admin.Image = Properties.Resources._3cham;
            pictureBox2.Image = Properties.Resources.danhgiavang;
            fpn.Visible = false;
            pn_chon.Visible = false;
        }

        public bool AA_admin
        {
            get { return pic_admin.Visible; }
            set { pic_admin.Visible = value; Invalidate(); }
        }
        public string AA_tensp
        {
            get { return lb_ten.Text; }
            set { lb_ten.Text = value; Invalidate(); }
        }
        public string AA_danhgia
        {
            get { return lb_danhgia.Text; }
            set { lb_danhgia.Text = value; Invalidate(); }
        }
        public string AA_daban
        {
            get { return lb_daban.Text; }
            set { lb_daban.Text = value; Invalidate(); }
        }
        public string AA_masp
        {
            get { return lb_masp.Text; }
            set { lb_masp.Text = value; Invalidate(); }
        }

        public bool AA_banggiamgia
        {
            get { return fpn.Visible; }
            set { fpn.Visible = value; Invalidate(); }
        }

        public Color AA_bg
        {
            get { return pn_bg.BackColor; }
            set { pn_bg.BackColor = value; Invalidate(); }
        }
        public Color AA_maunutthem
        {
            get { return bt_them.BackColor; }
            set { bt_them.BackColor = value; Invalidate(); }
        }
        public Image AA_anhnutthem
        {
            get { return bt_them.BackgroundImage; }
            set { bt_them.BackgroundImage = value; Invalidate(); }
        }
        public Image AA_anhsp
        {
            get { return pic_avata.Image; }
            set { pic_avata.Image = value; Invalidate(); }
        }
        public Color AA_maupnchon
        {
            get { return pn_chon.BackColor; }
            set { pn_chon.BackColor = value; Invalidate(); }
        }
        
        public string AA_xoatext
        {
            get { return bt_xoa.Text; }
            set { bt_xoa.Text = value; Invalidate(); }
        }
        public string AA_suatext
        {
            get { return bt_sua.Text; }
            set { bt_sua.Text = value; Invalidate(); }
        }

        public void xoasp(string color)
        {
            bt_them.BackColor = ColorTranslator.FromHtml(color);
            bt_them.BackgroundImage = Properties.Resources.add;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.BackColor = Color.Gray;
            bt_them.BackgroundImage = Properties.Resources.tick;
            THEMckick.Invoke(this, e);
        }

        private void pic_admin_Click(object sender, EventArgs e)
        {
            bt_xoa.BackColor = Color.White;
            bt_sua.BackColor = Color.White;
            if (pn_chon.Visible == false)
                pn_chon.Visible = true;
            else pn_chon.Visible = false;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bt_xoa.BackColor = Color.Green;
            pn_chon.Visible = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            bt_sua.BackColor = Color.Green;
            pn_chon.Visible= false;
        }
    }
}
