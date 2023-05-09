using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 成績紀錄2 : Form
    {
        public 成績紀錄2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int chinese = int.Parse(textBox2.Text);
            int english = int.Parse(textBox3.Text);
            int math = int.Parse(textBox4.Text);
            double a = (chinese + english + math);
            double b = ((chinese+english+math)/3);
            int max = Math.Max(chinese, Math.Max(english, math));
            int min = Math.Min(chinese, Math.Min(english, math));
            listBox1.Items.Add("                " + name+ "                " + chinese+ "                " + english+ "                " + math+ "                 " + a+ "                " + b+ "                " + min+ "               " + max);
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();      
            listBox1.Items.Add($"\t{rd.Next(1, 101)}\t{rd.Next(1, 101)}\t{rd.Next(1, 101)}\t{rd.Next(1, 101)}\t{rd.Next(1, 101)}\t{rd.Next(1, 101)}");
        }
    }
}
