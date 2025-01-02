using HiBanhMi_v1_1.Datacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_1.Forms
{
    public partial class FormMain : Form
    {
        Form activeform;
        OpenForm openForm = new OpenForm();
        public FormMain()
        {
            InitializeComponent();

            // chuc nang
            thanhChucNangChinh1.HomeClick += ThanhChucNangChinh1_HomeClick;
            thanhChucNangChinh1.MenuClick += ThanhChucNangChinh1_MenuClick;
            thanhChucNangChinh1.YeuThichClick += ThanhChucNangChinh1_YeuThichClick;
            thanhChucNangChinh1.LichSuClick += ThanhChucNangChinh1_LichSuClick;
            thanhChucNangChinh1.SettingClick += ThanhChucNangChinh1_SettingClick;

            openForm.openchildform(pn_main, activeform, new Forms.FormHome());
            pn_control.BringToFront();
        }

        private void ThanhChucNangChinh1_SettingClick(object sender, EventArgs e)
        {
        }

        private void ThanhChucNangChinh1_LichSuClick(object sender, EventArgs e)
        {
        }

        private void ThanhChucNangChinh1_YeuThichClick(object sender, EventArgs e)
        {
        }

        private void ThanhChucNangChinh1_MenuClick(object sender, EventArgs e)
        {
        }

        private void ThanhChucNangChinh1_HomeClick(object sender, EventArgs e)
        {
            openForm.openchildform(pn_main, activeform, new Forms.FormHome());
            pn_control.BringToFront();
        }

        private void pictureBoxCustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
