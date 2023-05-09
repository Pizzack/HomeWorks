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
    public partial class 圈圈叉叉 : Form
    {
        public 圈圈叉叉()
        {
            InitializeComponent();
        }
        public bool boolooxx = true;

     
        public void win()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            { MessageBox.Show("O勝利!"); END(); }



        }
        public void win1()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            { MessageBox.Show("X勝利!"); END(); } 
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            { MessageBox.Show("X勝利!"); END(); }

        }

        public void win2()
        {
            if (button1.Enabled == false &&
                button2.Enabled == false &&
                button3.Enabled == false &&
                button4.Enabled == false &&
                button5.Enabled == false &&
                button6.Enabled == false &&
                button7.Enabled == false &&
                button8.Enabled == false &&
                button9.Enabled == false)
            { MessageBox.Show("結束了，可按重新再一次"); }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button1.Text = "O"; }
            else
            { button1.Text = "X"; }
            button1.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();


        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button9.Text = "O"; }
            else
            { button9.Text = "X"; }
            button9.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button3.Text = "O"; }
            else
            { button3.Text = "X"; }
            button3.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button4.Text = "O"; }
            else
            { button4.Text = "X"; }
            button4.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button5.Text = "O"; }
            else
            { button5.Text = "X"; }
            button5.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button6.Text = "O"; }
            else
            { button6.Text = "X"; }
            button6.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button7.Text = "O"; }
            else
            { button7.Text = "X"; }
            button7.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            if (boolooxx == false)
            { button8.Text = "O"; }
            else
            { button8.Text = "X"; }
            button8.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (boolooxx == false)
            { button2.Text = "O"; }
            else
            { button2.Text = "X"; }
            button2.Enabled = false;
            boolooxx = !boolooxx;
            win(); win1(); win2();
        }
        private void END()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

    }
}
