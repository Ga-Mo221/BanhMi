using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class moform
    {
        public void Mo(Panel panel1, Form activeform, Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(activeform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
