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
    public partial class theme : Form
    {
        laytenfiletxt layten = new laytenfiletxt();
        private bool checkthaydoi = false;
        public theme()
        {
            InitializeComponent();
            this.Size = new Size(787, 640);

            // set color
            setcolor();
            // set ngon ngu
            setngonngu();

            string folderName = "theme";
            List<string> fileNames = layten.layten(folderName);
            layten.themlable(fpn_chude, fileNames, THEME.t[0]);

            layten.LabelClicked += Layten_LabelClicked;


            lb_themdachon.Text = US.us[1];
        }

        private void Layten_LabelClicked(object sender, Label e)
        {
            if (lb_themdachon.Text != e.Text)
            {
                e.BackColor = ColorTranslator.FromHtml(THEME.t[5]);
                lb_themdachon.Text = e.Text;
                lb_themdachon.ForeColor = Color.Green;
                checkthaydoi = true;
            }
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (checkthaydoi)
            {
                MessageBox.Show($"{NN.nn[43]}", $"{NN.nn[44]}", MessageBoxButtons.OK);
                US.us[1] = lb_themdachon.Text;
                GhiFile ghi = new GhiFile();
                ghi.Usersetting(US.us);
            }
        }




















        private void setcolor()
        {
            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);

            lb_chon.ForeColor = Color.Black;
            lb_chude.ForeColor = Color.Black;

            bt_xacnhan.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            lb_thongbao.ForeColor = Color.Black;
            lb_themdachon.ForeColor = Color.Red;
        }
        private void setngonngu()
        {
            lb_chude.Text = NN.nn[37];
            lb_chon.Text = NN.nn[39];
            bt_xacnhan.Text = NN.nn[19];
            lb_thongbao.Text = NN.nn[42];
        }

    }
}
