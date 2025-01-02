using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    /// <summary>
    /// theme
    /// </summary>
    internal static class THEME
    {
        public static List<string> t = new List<string>();
    }
    /// <summary>
    /// use setting
    /// </summary>
    internal static class US
    {
        public static List <string> us = new List<string>();
    }
    /// <summary>
    /// ngôn ngữ
    /// </summary>
    internal static class NN 
    {
        public static List<string> nn = new List<string>();
    }

    internal class Capnhat
    {
        DocFile df = new DocFile();
        public void updt()
        {
            df.US(US.us);
            df.Ngongu(NN.nn, US.us[0]);
            df.Theme(THEME.t, US.us[1]);
        }
    }
}
