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
    public partial class thanhchonsp : UserControl
    {
        public string chucnang;

        public event EventHandler tc_click;
        public event EventHandler bm_click;
        public event EventHandler cf_click;
        public event EventHandler gk_click;
        public thanhchonsp()
        {
            InitializeComponent();
        }


        public string AA_chucnang
        {
            get => chucnang;
            set => chucnang = value;
        }
        public string AA_tatca
        {
            get { return bt_tc.Text; }
            set { bt_tc.Text = value; Invalidate(); }
        }
        public string AA_banhmi
        {
            get { return bt_bm.Text; }
            set { bt_bm.Text = value; Invalidate(); }
        }
        public string AA_caphe
        {
            get { return bt_cf.Text; }
            set { bt_cf.Text = value; Invalidate(); }
        }
        public string AA_giaikhat
        {
            get { return bt_gk.Text; }
            set { bt_gk.Text = value; Invalidate(); }
        }


        public Color AA_bg
        {
            get { return panelCustom1.BackColor; }
            set { panelCustom1.BackColor = value; Invalidate(); }
        }
        public Color AA_mautc
        {
            get { return bt_tc.BackColor; }
            set { bt_tc.BackColor = value; Invalidate(); }
        }
        public Color AA_maubm
        {
            get { return bt_bm.BackColor; }
            set { bt_bm.BackColor = value; Invalidate(); }
        }
        public Color AA_maucp
        {
            get { return bt_cf.BackColor; }
            set { bt_cf.BackColor = value; Invalidate(); }
        }
        public Color AA_maugk
        {
            get { return bt_gk.BackColor; }
            set { bt_gk.BackColor = value; Invalidate(); }
        }


        private void bt_tc_Click(object sender, EventArgs e)
        {
            chucnang = "TC";
            tc_click?.Invoke(this, EventArgs.Empty);
        }

        private void bt_bm_Click(object sender, EventArgs e)
        {
            chucnang = "BM";
            bm_click?.Invoke(this, EventArgs.Empty);
        }

        private void bt_cf_Click(object sender, EventArgs e)
        {
            chucnang = "CP";
            cf_click?.Invoke(this, EventArgs.Empty);
        }

        private void bt_gk_Click(object sender, EventArgs e)
        {
            chucnang = "GK";
            gk_click?.Invoke(this, EventArgs.Empty);
        }
    }
}
