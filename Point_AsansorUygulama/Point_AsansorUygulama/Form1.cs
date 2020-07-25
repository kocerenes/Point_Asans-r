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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = new Point();
            point.X = Convert.ToInt32(textBox1.Text);
            point.Y = Convert.ToInt32(textBox2.Text);
            pictureBox1.Location = point;
        }
    }
}
