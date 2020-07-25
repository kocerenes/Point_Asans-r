using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_AsansorUygulama
{
    public partial class Frm_Asansör : Form
    {
        public Frm_Asansör()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblKat.Text=="0")
            {
                lblKat.Text = "1";
                timer1.Start();
            }
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {            
            if (lblKat.Text=="1")
            {
                lblKat.Text = "0";
                timer1.Start();
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblKat.Text=="1")
            {
                btnAsansor.Top -= 5;
                if (btnAsansor.Location.Y<=187)
                {
                    timer1.Stop();
                }
            }

            if (lblKat.Text=="0")
            {
                btnAsansor.Top += 5;
                if (btnAsansor.Location.Y>=405)
                {
                    timer1.Stop();
                }
            }

        }
    }
}
