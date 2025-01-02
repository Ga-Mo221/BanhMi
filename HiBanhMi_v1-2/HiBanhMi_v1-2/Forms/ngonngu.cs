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
    public partial class ngonngu : Form
    {
        laytenfiletxt layten = new laytenfiletxt();
        private bool checkthaydoi = false;
        public ngonngu()
        {
            InitializeComponent();

            // set color
            setcolor();
            // set ngon ngu
            setngonngu();


            string folderName = "ngonngu";
            List<string> fileNames = layten.layten(folderName);
            layten.themlable(fpn_ngonngu, fileNames, THEME.t[0]);

            layten.LabelClicked += Layten_LabelClicked;


            lb_ngonngudachon.Text = US.us[0];
        }

        private void Layten_LabelClicked(object sender, Label e)
        {
            if (lb_ngonngudachon.Text != e.Text)
            {
                e.BackColor = ColorTranslator.FromHtml(THEME.t[5]);
                lb_ngonngudachon.Text = e.Text;
                lb_ngonngudachon.ForeColor = Color.Green;
                checkthaydoi = true;
            }
        }

        

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (checkthaydoi)
            {
                MessageBox.Show($"{NN.nn[43]}", $"{NN.nn[44]}", MessageBoxButtons.OK);
                US.us[0] = lb_ngonngudachon.Text;
                GhiFile ghi = new GhiFile();
                ghi.Usersetting(US.us);
            }
        }















        private void setcolor()
        {
            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);

            lb_chon.ForeColor = Color.Black;
            lb_ngonngu.ForeColor = Color.Black;

            bt_xacnhan.BackColor = ColorTranslator.FromHtml(THEME.t[2]);

            lb_thongbao.ForeColor = Color.Black;
            lb_ngonngudachon.ForeColor = Color.Red;
        }
        private void setngonngu()
        {
            lb_ngonngu.Text = NN.nn[36];
            lb_chon.Text = NN.nn[40];
            bt_xacnhan.Text = NN.nn[19];
            lb_thongbao.Text = NN.nn[41];
        }

    }
}
