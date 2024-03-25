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

        public frm_Home()
        {
            InitializeComponent();
            btnClick = false;
            panel3.Width = 82;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel3.Width <= 82){
                panel3.Width = 160;
            } else
            {
                panel3.Width = 82;
            }
        }
    }
}
