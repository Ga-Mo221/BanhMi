using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal static class tkon
    {
        // Thuộc tính tĩnh - dùng để lưu trạng thái tài khoản đăng nhập hiện tại
        public static string Tkc { get; set; } = "Chưa có tk";
        public static string Emailc { get; set; } = "Chưa có email";
        public static string Mkc { get; set; } = "Chưa có mk";
        public static int sldn { get; set; } = 0;
    }
}
