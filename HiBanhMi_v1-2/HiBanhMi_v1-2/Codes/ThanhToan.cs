using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class ThanhToan
    {
        GhiFile ghi = new GhiFile();
        private string taomadonhangtudong(int length)
        {
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder result = new StringBuilder(length);
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    result.Append(chars[random.Next(chars.Length)]);
                }

                return result.ToString();
            }
        }
        
        
        public void tt()
        {
            if (GioHang.soluongsanpham > 0)
            {
                string madon = taomadonhangtudong(10);

                DateTime baygio = DateTime.Now;
                string thoigian = baygio.ToString("dd-MM-yyyy HH:mm");

                string tongtien = GioHang.tonggia.ToString();

                ghi.Lichsudonhang(new lichsudonhang(madon, tkon.Tkc, thoigian, tongtien));
                tungsanpham(madon);


                GioHang.danhSachSanPham = new List<sanpham>();
                GioHang.soluongsanpham = 0;
                GioHang.tonggia = 0;
                MessageBox.Show(NN.nn[68], NN.nn[69], MessageBoxButtons.OK);
            }
        }

        private void tungsanpham(string madon)
        {
            foreach (var sp in GioHang.danhSachSanPham)
            {
                ghi.LichSuSanPham(new lichsusanpham(madon, tkon.Tkc, sp.id,sp.img, sp.ten, sp.soluong.ToString(), sp.giagoc.ToString(), sp.giacuoi.ToString()));
                ThayDoiSoLuongDaban(sp.id, sp.soluong);
            }
        }

        private void ThayDoiSoLuongDaban(string id, int daban)
        {
            foreach (var s in listsp.sanphams)
            {
                if (s.id == id)
                {
                    KiemTraLoaiSP(s, daban);
                }
            }
        }


        private void KiemTraLoaiSP(sanpham sp, int daban)
        {
            switch (sp.id[0])
            {
                case 'B':
                    {
                        BanhMi bm = (BanhMi)sp;
                        bm.daban += daban;
                        break;
                    }
                case 'C':
                    {
                        Caphe cp = (Caphe)sp;
                        cp.daban += daban;
                        break;
                    }
                case 'G':
                    {
                        Giaikhat gk = (Giaikhat)sp;
                        gk.daban += daban;
                        break;
                    }
            }
            ghi.SanPham(listsp.sanphams);
        }
    }
}
