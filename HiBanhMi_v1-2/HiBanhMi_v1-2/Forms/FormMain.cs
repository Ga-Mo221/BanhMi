using HiBanhMi_v1_2.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Forms
{
    public partial class FormMain : Form
    {
        // bien
        moform openf = new moform();
        Form acctiveform = new Form();
        DocFile df = new DocFile();
        upuson up = new upuson();
        //Capnhat cn = new Capnhat();


        public FormMain()
        {
            InitializeComponent();
            this.Size = new Size(1400, 800);
            listsp.sanphams.Clear();
            listct.lssp.Clear();
            listyt.yt.Clear();
            userlist.users.Clear();
            df.sanpham(listsp.sanphams);
            df.users(userlist.users);
            df.YeuThich(listyt.yt);
            up.up(tkon.Tkc);
            //cn.updt();

            chonchucnang("home");
            // setting NN.nn
            tcn.AA_ten = uson.users.hoten;

            tcn.AA_anhdaidien = img.LoadImageWithoutLocking(img.getpathImg("avatar", uson.users.avata));

            //tcn.AA_anhdaidien = Image.FromFile(img.getpathImg(uson.users.avata));
            //set colo
            setcolor();
            //set ngonngu
            setngonngu();


            tcn.Homeclick += Tcn_Homeclick;
            tcn.ThucDonclick += Tcn_ThucDonclick;
            tcn.YeuThichclick += Tcn_YeuThichclick;
            tcn.LichSuclick += Tcn_LichSuclick;
            tcn.Settingclick += Tcn_Settingclick;

            openf.Mo(pn_hienthi, acctiveform, new Homeform());
        }

        private void setngonngu()
        {
            tcn.AA_1hometext = NN.nn[23];
            tcn.AA_2thucdontext = NN.nn[24];
            tcn.AA_3yeuthichtext = NN.nn[25];
            tcn.AA_4lichsutext = NN.nn[26];
            tcn.AA_5settingtext = NN.nn[27];
        }
        private void setcolor()
        {
            this.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            tcn.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            bt_exit.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            bt_thunho.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
        }


        public void chonchucnang(string nut)
        {
            switch (nut)
            {
                case "home":
                    {
                        tcn.AA_1homebg = ColorTranslator.FromHtml(THEME.t[3]);
                        tcn.AA_1homeicon = ColorTranslator.FromHtml(THEME.t[5]);
                        tcn.AA_1homeTitle = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_2thucdonbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_2thucdonicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_2thucdonTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_3yeuthichbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_3yeuthichicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_3yeuthichTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_4lichsubg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_4lichsuicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_4lichsuTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_5settingbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_5settingicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_5settingTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        break;
                    }
                case "thucdon":
                    {
                        tcn.AA_1homebg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_1homeicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_1homeTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_2thucdonbg = ColorTranslator.FromHtml(THEME.t[3]);
                        tcn.AA_2thucdonicon = ColorTranslator.FromHtml(THEME.t[5]);
                        tcn.AA_2thucdonTitle = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_3yeuthichbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_3yeuthichicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_3yeuthichTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_4lichsubg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_4lichsuicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_4lichsuTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_5settingbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_5settingicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_5settingTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        break;
                    }
                case "yeuthich":
                    {
                        tcn.AA_1homebg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_1homeicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_1homeTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_2thucdonbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_2thucdonicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_2thucdonTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_3yeuthichbg = ColorTranslator.FromHtml(THEME.t[3]);
                        tcn.AA_3yeuthichicon = ColorTranslator.FromHtml(THEME.t[5]);
                        tcn.AA_3yeuthichTitle = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_4lichsubg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_4lichsuicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_4lichsuTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_5settingbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_5settingicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_5settingTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        break;
                    }
                case "lichsu":
                    {
                        tcn.AA_1homebg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_1homeicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_1homeTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_2thucdonbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_2thucdonicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_2thucdonTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_3yeuthichbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_3yeuthichicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_3yeuthichTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_4lichsubg = ColorTranslator.FromHtml(THEME.t[3]);
                        tcn.AA_4lichsuicon = ColorTranslator.FromHtml(THEME.t[5]);
                        tcn.AA_4lichsuTitle = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_5settingbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_5settingicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_5settingTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        break;
                    }
                case "setting":
                    {
                        tcn.AA_1homebg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_1homeicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_1homeTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_2thucdonbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_2thucdonicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_2thucdonTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_3yeuthichbg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_3yeuthichicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_3yeuthichTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_4lichsubg = ColorTranslator.FromHtml(THEME.t[1]);
                        tcn.AA_4lichsuicon = ColorTranslator.FromHtml(THEME.t[0]);
                        tcn.AA_4lichsuTitle = ColorTranslator.FromHtml(THEME.t[4]);
                        tcn.AA_5settingbg = ColorTranslator.FromHtml(THEME.t[3]);
                        tcn.AA_5settingicon = ColorTranslator.FromHtml(THEME.t[5]);
                        tcn.AA_5settingTitle = ColorTranslator.FromHtml(THEME.t[0]);
                        break;
                    }
            }
        }
        

        private void Tcn_Homeclick(object sender, EventArgs e)
        {
            chonchucnang("home");
            openf.Mo(pn_hienthi, acctiveform, new Homeform());
        }
        private void Tcn_ThucDonclick(object sender, EventArgs e)
        {
            chonchucnang("thucdon");
            openf.Mo(pn_hienthi, acctiveform, new ThucDonform());
        }
        private void Tcn_YeuThichclick(object sender, EventArgs e)
        {
            chonchucnang("yeuthich");
            openf.Mo(pn_hienthi, acctiveform, new YeuThichform());
        }
        private void Tcn_LichSuclick(object sender, EventArgs e)
        {
            chonchucnang("lichsu");
            openf.Mo(pn_hienthi, acctiveform, new LichSuform());
        }
        private void Tcn_Settingclick(object sender, EventArgs e)
        {
            chonchucnang("setting");
            openf.Mo(pn_hienthi, acctiveform, new Settingform());
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_thunho_Click_1(object sender, EventArgs e)
        {

        }

    }
}
