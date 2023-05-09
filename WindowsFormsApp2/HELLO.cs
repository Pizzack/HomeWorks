using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class HELLO : Form
    {
        public HELLO()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string name1 = textBox2.Text;
            string name2 = textBox3.Text;
            string name3 = textBox4.Text;
            MessageBox.Show("HI!我是:" + name + "英文名字是:" + name1 + "性別是:" + name2 + "星座是:" + name3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string name1 = textBox2.Text;
            string name2 = textBox3.Text;
            string name3 = textBox4.Text;
            MessageBox.Show("Hello!我是:" + name + "英文名字是:" + name1 + "性別是:" + name2 + "星座是:" + name3);
        }

        private void HELLO_Load(object sender, EventArgs e)
        {

        }
    }
}
