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
    public partial class chitietdonhang : Form
    {
        GhiFile ghi = new GhiFile();
        DocFile doc = new DocFile();
        loadlichsu load = new loadlichsu();
        public chitietdonhang()
        {
            InitializeComponent();

            listct.lssp.Clear();
            doc.LichSuSanPham(listct.lssp);


            setngonngu();
            setcolor();

            pn_danhgia.Visible = false;
        }
        private void chitietdonhang_Load(object sender, EventArgs e)
        {
            load.LoadChiTietDonHang(fpn, lb_madon.Text);
        }
        private void bt_gui_Click(object sender, EventArgs e)
        {
            if (tb_chude.Text.Length == 0)
            {
                lb_thongbao.Text = NN.nn[76];
                lb_thongbao.ForeColor = Color.Red;
                return;
            }
            if (tb_noidung.Text.Length == 0)
            {
                lb_thongbao.Text = NN.nn[77];
                lb_thongbao.ForeColor= Color.Red;
                return;
            }


            ghi.DanhGia(new danhgia(lb_masp.Text, lb_img.Text, uson.users.hoten, tb_chude.Text, tb_noidung.Text));

            tb_chude.Text = "";
            tb_noidung.Text = "";

            MessageBox.Show(NN.nn[79], NN.nn[80], MessageBoxButtons.OK);

            pn_danhgia.Visible = false;
        }
        private void bt_huy_Click(object sender, EventArgs e)
        {
            tb_chude.Text = "";
            tb_noidung.Text = "";
            pn_danhgia.Visible=false;
        }












        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setngonngu()
        {
            lb_danhgia.Text = NN.nn[32];
            lb_chude.Text = NN.nn[37];
            lb_noidung.Text = NN.nn[73];
            bt_gui.Text = NN.nn[74];
            lb_thongbao.Text = NN.nn[75];
            bt_huy.Text = NN.nn[78];
        }
        private void setcolor()
        {
            panel1.BackColor = ColorTranslator.FromHtml(THEME.t[3]);
            button1.BackColor = ColorTranslator.FromHtml(THEME.t[3]);
            BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            pn_danhgia.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            pn_chude.BackColor = ColorTranslator.FromHtml(THEME.t[7]);
            pn_noidung.BackColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_chude.BackColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_noidung.BackColor = ColorTranslator.FromHtml (THEME.t[7]);
            bt_gui.BackColor = ColorTranslator.FromHtml(THEME.t[4]);
            bt_huy.BackColor = ColorTranslator.FromHtml(THEME.t[4]);
        }

    }
}
