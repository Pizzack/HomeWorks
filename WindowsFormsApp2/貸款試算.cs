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
    public partial class 貸款試算 : Form
    {
        public 貸款試算()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            double A, B, C, D, R, N;
            if (!double.TryParse(textBox1.Text, out A))
            {
                MessageBox.Show("請輸入有效的房價");
                return;
            }

            if (!double.TryParse(textBox2.Text, out B))
            {
                MessageBox.Show("請輸入有效的貸款年限");
                return;
            }

            if (!double.TryParse(textBox3.Text, out C))
            {
                MessageBox.Show("請輸入有效的年利率");
                return;
            }

            if (!double.TryParse(textBox4.Text, out D))
            {
                MessageBox.Show("請輸入有效的頭期款");
                return;
            }

            R = C / 12 / 100; // 计算月利率，注意需要将年利率除以 12 和 100
            N = B * 12; // 计算总月数，将贷款年限乘以 12

            double PerMon = (A - D) * R * Math.Pow(1 + R, N) / (Math.Pow(1 + R, N) - 1); // 计算每月还款额
            MessageBox.Show("你的月付款為:" + PerMon);

        }

        public void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            if (!double.TryParse(textBox1.Text, out a) || a < 0)
            {
                MessageBox.Show("請輸入有效的房價");
                return;
            }

            if (!double.TryParse(textBox2.Text, out b) || b < 0)
            {
                MessageBox.Show("請輸入有效的貸款年限");
                return;
            }

            if (!double.TryParse(textBox3.Text, out c) || c < 0)
            {
                MessageBox.Show("請輸入有效的年利率");
                return;
            }

            if (!double.TryParse(textBox4.Text, out d) || d < 0)
            {
                MessageBox.Show("請輸入有效的頭期款");
                return;
            }

            double Total;
            if (b == 0)
            {
                Total = a + (a - d) * c * (1 + c / 12) / 24;
            }
            else
            {
                double r = b / 12;
                Total = a * Math.Pow(1 + r, c) + (a - d) * r * ((Math.Pow(1 + r, c) - 1) / (Math.Pow(1 + r, c) * r));
            }

            MessageBox.Show("你的總付款為:" + Total);
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
          
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetTextBoxValue()
        {
            return textBox1.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double A, B, C, D, R, N;
            if (!double.TryParse(textBox1.Text, out A))
            {
                MessageBox.Show("請輸入有效的房價");
                return;
            }

            if (!double.TryParse(textBox2.Text, out B))
            {
                MessageBox.Show("請輸入有效的貸款年限");
                return;
            }

            if (!double.TryParse(textBox3.Text, out C))
            {
                MessageBox.Show("請輸入有效的年利率");
                return;
            }

            if (!double.TryParse(textBox4.Text, out D))
            {
                MessageBox.Show("請輸入有效的頭期款");
                return;
            }

            R = C / 12 / 100; // 计算月利率，注意需要将年利率除以 12 和 100
            N = B * 12; // 计算总月数，将贷款年限乘以 12

            double PerMon = (A - D) * R * Math.Pow(1 + R, N) / (Math.Pow(1 + R, N) - 1);






            double a, b, c, d;

            if (!double.TryParse(textBox1.Text, out a) || a < 0)
            {
                MessageBox.Show("請輸入有效的房價");
                return;
            }

            if (!double.TryParse(textBox2.Text, out b) || b < 0)
            {
                MessageBox.Show("請輸入有效的貸款年限");
                return;
            }

            if (!double.TryParse(textBox3.Text, out c) || c < 0)
            {
                MessageBox.Show("請輸入有效的年利率");
                return;
            }

            if (!double.TryParse(textBox4.Text, out d) || d < 0)
            {
                MessageBox.Show("請輸入有效的頭期款");
                return;
            }

            double Total;
            if (b == 0)
            {
                Total = a + (a - d) * c * (1 + c / 12) / 24;
            }
            else
            {
                double r = b / 12;
                Total = a * Math.Pow(1 + r, c) + (a - d) * r * ((Math.Pow(1 + r, c) - 1) / (Math.Pow(1 + r, c) * r));
            }



            貸款試算2 form1 = new 貸款試算2();
            form1.Show();
            form1.label5.Text = textBox1.Text;
            form1.label6.Text = textBox2.Text;
            form1.label7.Text = textBox3.Text;
            form1.label8.Text = textBox4.Text;
            form1.label9.Text = PerMon.ToString();
            form1.label10.Text = Total.ToString();


        }
    }
}
