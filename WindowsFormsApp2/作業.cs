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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HELLO hello = new HELLO();
            hello.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            貸款試算 LOAN = new 貸款試算();
            LOAN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            收銀機 POS = new 收銀機();
            POS.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            成績紀錄 GRADE = new 成績紀錄();
            GRADE.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            成績紀錄2 GRADE = new 成績紀錄2();
            GRADE.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            陣列 METGOD = new 陣列();
            METGOD.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            陣列2 METGOD = new 陣列2();
            METGOD.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            加減乘除計算機 CU=new 加減乘除計算機();   
            CU.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            圈圈叉叉 OOXX = new 圈圈叉叉();
            OOXX.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           猜數字遊戲 guess = new 猜數字遊戲();
            guess.Show();
        }
    }
}
