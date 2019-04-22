using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledz_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float u1 = float.Parse(textBox1.Text);
            float u2 = float.Parse(textBox2.Text);
            float i1 = float.Parse(textBox3.Text);
            string res = ((u1 - u2) / i1).ToString();
            textBox4.Text = res;
        }
    }
}
