using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace HiBanhMi_v1_2.Codes
{
    internal class TaiKhoan
    {
        
        private string tk;
        private string email;
        private string mk;

        public string Tk
        {
            get => tk;
            set => tk = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Mk
        {
            get => mk;
            set => mk = value;
        }
        

        public TaiKhoan() { }
        public TaiKhoan(string tk, string email, string mk)
        {
            this.tk = tk;
            this.email = email;
            this.mk = mk;
        }

        public override string ToString()
        {
            return $"{this.tk},{this.email},{this.mk}";
        }
    }
    internal static class tk
    {
        public static List<TaiKhoan> TK = new List<TaiKhoan>();
    }
}
