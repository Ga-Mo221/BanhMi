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
    public partial class Homeform : Form
    {
        loaditem litem = new loaditem();
        private FormMain formMain;
        DocFile doc = new DocFile();
        public Homeform()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);
            
            listdg.dg.Clear();
            doc.DanhGia(listdg.dg);
            
            // setup ngon ngu
            setngonngu();
            // setup mau
            setcolor();
            KiemTraSanPhamGiamGia();

            thucdon1.ChonthucdonClick += Thucdon1_ChonthucdonClick;
            thucdon2.ChonthucdonClick += Thucdon2_ChonthucdonClick;
            thucdon3.ChonthucdonClick += Thucdon3_ChonthucdonClick;
            thucdon4.ChonthucdonClick += Thucdon4_ChonthucdonClick;

            litem.Load(fpn_home, "TC");
        }
        private void bt_giohang_Click(object sender, EventArgs e)
        {
            giohang gh = new giohang();
            gh.ShowDialog();
        }

        private void bt_danhgia_Click(object sender, EventArgs e)
        {

        }





        private void Thucdon4_ChonthucdonClick(object sender, EventArgs e)
        {
            xulychonthucdon(4);
            lb_luachon.Text = thucdon4.AA_Title;
            litem.Load(fpn_home, "GK");
        }

        private void Thucdon3_ChonthucdonClick(object sender, EventArgs e)
        {
            xulychonthucdon(3);
            lb_luachon.Text = thucdon3.AA_Title;
            litem.Load(fpn_home, "CP");
        }

        private void Thucdon2_ChonthucdonClick(object sender, EventArgs e)
        {
            xulychonthucdon(2);
            lb_luachon.Text = thucdon2.AA_Title;
            litem.Load(fpn_home, "BM");
        }

        private void Thucdon1_ChonthucdonClick(object sender, EventArgs e)
        {
            xulychonthucdon(1);
            lb_luachon.Text = thucdon1.AA_Title;
            litem.Load(fpn_home, "TC");
        }
        private void bt_xemthem_Click(object sender, EventArgs e)
        {
            formMain = (FormMain)Application.OpenForms["FormMain"];
            if (formMain != null)
            {
                formMain.tcn.TriggerThucDonClick();
            }
            else
            {
                MessageBox.Show("Thể hiện của FormMain không tồn tại.");
            }
        }

        private void xulychonthucdon(int tt)
        {
            switch (tt)
            {
                case 1:
                    {
                        thucdon2.quaylai(THEME.t[8]);
                        thucdon3.quaylai(THEME.t[8]);
                        thucdon4.quaylai(THEME.t[8]);
                        break;
                    }
                case 2:
                    {
                        thucdon1.quaylai(THEME.t[8]);
                        thucdon3.quaylai(THEME.t[8]);
                        thucdon4.quaylai(THEME.t[8]);
                        break;
                    }
                case 3:
                    {
                        thucdon1.quaylai(THEME.t[8]);
                        thucdon2.quaylai(THEME.t[8]);
                        thucdon4.quaylai(THEME.t[8]);
                        break;
                    }
                case 4:
                    {
                        thucdon1.quaylai(THEME.t[8]);
                        thucdon2.quaylai(THEME.t[8]);
                        thucdon3.quaylai(THEME.t[8]);
                        break;
                    }
            }
        }

        private void KiemTraSanPhamGiamGia()
        {
            int sale = 0;
            string tensp = null;

            foreach (var sp in listsp.sanphams)
            {
                if (sale < sp.sale)
                {
                    sale = sp.sale;
                    tensp = sp.ten;
                }
            }
            lb_phantramgiam.Text = sale.ToString();
            lb_tensp.Text = tensp;
        }












        private void setngonngu()
        {
            lb_loichao1.Text = NN.nn[28];
            lb_loichao2.Text = NN.nn[29];

            lb_xemthem.Text = NN.nn[31];

            lb_giam.Text = NN.nn[30];
            
            lb_danhgia.Text = NN.nn[32];

            lb_luachon.Text = NN.nn[31];

            thucdon1.AA_Title = NN.nn[31];
            thucdon2.AA_Title = NN.nn[33];
            thucdon3.AA_Title = NN.nn[34];
            thucdon4.AA_Title = NN.nn[35];
            lb_noidunggiamgia.Text = NN.nn[66];
        }
        private void setcolor()
        {
            lb_loichao1.ForeColor = Color.Black;
            lb_loichao2.ForeColor = Color.Black;
            lb_luachon.ForeColor = Color.Black;
            lb_xemthem.ForeColor = Color.Black;
            lb_chude1.ForeColor = Color.Black;
            lb_chude2.ForeColor = Color.Black;
            lb_chude3.ForeColor = Color.Black;
            lb_danhgia.ForeColor = Color.Black;
            lb_noidungchude1.ForeColor= Color.Black;
            lb_noidungchude2.ForeColor= Color.Black;
            lb_noidungchude3.ForeColor= Color.Black;

            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            pn_giamgia.BackColor = ColorTranslator.FromHtml (THEME.t[2]);
            pn_cd1.BackColor = ColorTranslator.FromHtml(THEME.t[6]);
            pn_cd2.BackColor = ColorTranslator.FromHtml(THEME.t[7]);
            pn_cd3.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
            bt_giohang.BackColor = ColorTranslator.FromHtml(THEME.t[4]);
            bt_danhgia.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
            bt_xemthem.BackColor = ColorTranslator.FromHtml(THEME.t[9]);


            thucdon1.AA_maukhinhan = THEME.t[2];
            thucdon2.AA_maukhinhan = THEME.t[2];
            thucdon3.AA_maukhinhan = THEME.t[2];
            thucdon4.AA_maukhinhan = THEME.t[2];
            thucdon1.quaylai(THEME.t[2]);
            thucdon2.quaylai(THEME.t[8]);
            thucdon3.quaylai(THEME.t[8]);
            thucdon4.quaylai(THEME.t[8]);
        }

    }
}
