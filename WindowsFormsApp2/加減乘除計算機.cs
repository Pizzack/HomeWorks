using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 加減乘除計算機 : Form
    {
        public 加減乘除計算機()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a + b;
            textBox3.Text = c.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a - b;
            textBox3.Text = c.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a * b;
            textBox3.Text = c.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a / b;
            textBox3.Text = c.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
