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
    public partial class ThucDonform : Form
    {
        GioHang gh = new GioHang();
        loaditem lit = new loaditem();
        public ThucDonform()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);
            lit.Load(fpn_sp, fpn_sanpham, lb_tongtien, "TC");
            gh.loadGH(fpn_sanpham, lb_tongtien);


            // sét color
            setcolor();
            // set ngôn ngữ
            setngonngu();


            thanhchonsp.tc_click += Thanhchonsp_tc_click;
            thanhchonsp.bm_click += Thanhchonsp_bm_click;
            thanhchonsp.cf_click += Thanhchonsp_cf_click;
            thanhchonsp.gk_click += Thanhchonsp_gk_click;

            thanhtimkiem.textchanged += Thanhtimkiem_textchanged;
        }

        private void Thanhtimkiem_textchanged(object sender, EventArgs e)
        {
        }

        private void Thanhchonsp_gk_click(object sender, EventArgs e)
        {
            ChonSanPham("gk");
            lit.Load(fpn_sp, fpn_sanpham, lb_tongtien, "GK");
        }

        private void Thanhchonsp_cf_click(object sender, EventArgs e)
        {
            ChonSanPham("cp");
            lit.Load(fpn_sp, fpn_sanpham, lb_tongtien, "CP");
        }

        private void Thanhchonsp_bm_click(object sender, EventArgs e)
        {
            ChonSanPham("bm");
            lit.Load(fpn_sp, fpn_sanpham, lb_tongtien, "BM");
        }

        private void Thanhchonsp_tc_click(object sender, EventArgs e)
        {
            ChonSanPham("tc");
            lit.Load(fpn_sp, fpn_sanpham, lb_tongtien, "TC");
        }
        private void ChonSanPham(string sp)
        {
            switch (sp)
            {
                case "tc":
                    {
                        thanhchonsp.AA_maubm = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maucp = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maugk = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_mautc = ColorTranslator.FromHtml(THEME.t[4]);
                        break;
                    }
                case "bm":
                    {
                        thanhchonsp.AA_maubm = ColorTranslator.FromHtml(THEME.t[4]);
                        thanhchonsp.AA_maucp = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maugk = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_mautc = ColorTranslator.FromHtml(THEME.t[2]);
                        break;
                    }
                case "cp":
                    {
                        thanhchonsp.AA_maubm = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maucp = ColorTranslator.FromHtml(THEME.t[4]);
                        thanhchonsp.AA_maugk = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_mautc = ColorTranslator.FromHtml(THEME.t[2]);
                        break;
                    }
                case "gk":
                    {
                        thanhchonsp.AA_maubm = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maucp = ColorTranslator.FromHtml(THEME.t[2]);
                        thanhchonsp.AA_maugk = ColorTranslator.FromHtml(THEME.t[4]);
                        thanhchonsp.AA_mautc = ColorTranslator.FromHtml(THEME.t[2]);
                        break;
                    }
            }
        }
        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            fpn_sanpham.Controls.Clear();
            tt.tt();
        }






















        private void setcolor()
        {
            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            lb_tieude1.ForeColor = Color.Black;
            lb_tieude2.ForeColor = Color.Black;

            thanhchonsp.AA_bg = ColorTranslator.FromHtml(THEME.t[7]);
            thanhchonsp.AA_maubm = ColorTranslator.FromHtml(THEME.t[2]);
            thanhchonsp.AA_maucp = ColorTranslator.FromHtml(THEME.t[2]);
            thanhchonsp.AA_maugk = ColorTranslator.FromHtml(THEME.t[2]);
            thanhchonsp.AA_mautc = ColorTranslator.FromHtml(THEME.t[2]);

            thanhtimkiem.BackColor = ColorTranslator.FromHtml (THEME.t[6]);
            thanhtimkiem.AA_mau = ColorTranslator.FromHtml(THEME.t[6]);

            pn_giohang.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
            bt_thanhtoan.BackColor = ColorTranslator.FromHtml(THEME.t[4]);
        }
        private void setngonngu()
        {
            lb_tieude1.Text = NN.nn[61];
            lb_tieude2.Text = NN.nn[62];

            thanhchonsp.AA_tatca = NN.nn[31];
            thanhchonsp.AA_banhmi = NN.nn[33];
            thanhchonsp.AA_caphe = NN.nn[34];
            thanhchonsp.AA_giaikhat = NN.nn[35];

            lb_giohang.Text = NN.nn[63];
            lb_tong.Text = NN.nn[64];
            bt_thanhtoan.Text = NN.nn[65];
        }

    }
}
