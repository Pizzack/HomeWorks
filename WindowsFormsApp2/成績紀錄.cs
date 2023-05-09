using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class 成績紀錄 : Form 
    { 
     
       class score
        {
            public string name ;
            public int chinese ;
            public int english ;
            public int math    ;
        }
        
        public 成績紀錄()
        {
            InitializeComponent();
        }
        score mum1 = new score();
        public void button1_Click(object sender, EventArgs e)
        {
   
            mum1.name = textBox1.Text;
            mum1.chinese = int.Parse(textBox2.Text);
            mum1.english = int.Parse(textBox3.Text);
            mum1.math = int.Parse(textBox4.Text);
        }
        public void button2_Click(object sender, EventArgs e)
        {
          
            textBox5.Text = 
                "姓名:" + mum1.name + Environment.NewLine +
                "國文:" + mum1.chinese + Environment.NewLine +
                "英文:" + mum1.english + Environment.NewLine +
                "數學:" + mum1.math;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int max = Math.Max(mum1.chinese, Math.Max(mum1.english, mum1.math));
            int min = Math.Min(mum1.chinese, Math.Min(mum1.english, mum1.math));
            string maxSubject = "", minSubject = "";
            if (max == mum1.chinese) maxSubject = "國文";
            if (max == mum1.english) maxSubject = "英文";
            if (max == mum1.math) maxSubject = "數學";
            if (min == mum1.chinese) minSubject = "國文";
            if (min == mum1.english) minSubject = "英文";
            if (min == mum1.math) minSubject = "數學";
            textBox6.Text = "最高分科目：" + maxSubject + " " + max + Environment.NewLine +
                         "最低分科目：" + minSubject + " " + min;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
