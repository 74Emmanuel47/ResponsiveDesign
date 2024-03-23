using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDS_MANAGER_PROJECT
{
    public partial class frm_Home : Form
    {
        private bool btnClick;
        private bool btn3Click;

        public frm_Home()
        {
            InitializeComponent();
            btnClick = false;
            btn3Click = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(138, 138, 255);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if(!btnClick )
                button2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(138, 138, 255);
            btnClick = true;
        }
    }
}
