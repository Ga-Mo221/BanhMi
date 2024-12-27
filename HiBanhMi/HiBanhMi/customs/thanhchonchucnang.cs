using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi.customs
{
    public partial class thanhchonchucnang : UserControl
    {
        //bien
        ImageManager taianh = new ImageManager();

        public thanhchonchucnang()
        {
            InitializeComponent();

            //pnthanhchontrai
            pnthanhchontrai.Size = new Size(80, 420);
            pnthanhchontrai.Location = new Point(0, 130);

            // chon
            //taianh.LoadImage(picChon, "thanhchontrai", "Chon");
            picChon.Size = new Size(81, 140);
            picChon.Location = new Point(0, 26);

            // Home
            picHome.Location = new Point(20, 75);
            picHome.Size = new Size(40, 40);

            // Menu
            picMenu.Location = new Point(20, 132);
            picMenu.Size = new Size(40, 40);

            // Yeu thich
            picYeuthich.Location = new Point(20, 189);
            picYeuthich.Size = new Size(40, 40);

            // Lich su
            picLichsu.Location = new Point(20, 246);
            picLichsu.Size = new Size(40, 40);

            // setting
            picSetting.Location = new Point(20, 303);
            picSetting.Size = new Size(40, 40);
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }
        private void picMenu_Click(object sender, EventArgs e)
        {

        }
        private void picYeuthich_Click(object sender, EventArgs e)
        {

        }

        private void picLichsu_Click(object sender, EventArgs e)
        {

        }

        private void picSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
