using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class 收銀機 : Form
    {
        int beerQ = 0;       // 啤酒數量
        int tequilaQ = 0;    // 龍舌蘭酒數量
        int whiskyQ = 0;     // 威士忌數量
        int wineQ = 0;       // 紅酒數量

        int beerP = 120;     // 啤酒價格
        int tequilaP = 160;  // 龍舌蘭酒價格
        int whiskyP = 350;   // 威士忌價格
        int wineP = 320;     // 紅酒價格

        int totalP = 0;      //總價

        public 收銀機()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            beerQ++;
            beerP = 120 * beerQ;
            totalP += 120;
            show();
            txtTotalAmount.Text = "NT:$" + totalP.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            tequilaQ++;
            tequilaP = 160 * tequilaQ;
            totalP += 160;
            show();
            txtTotalAmount.Text = "NT:$" + totalP.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            whiskyQ++;
            whiskyP = 350 * whiskyQ;
            totalP += 350;
            show();
            txtTotalAmount.Text = "NT:$" + totalP.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            wineQ++;
            wineP = 320 * wineQ;
            totalP += 320;
            show();
            txtTotalAmount.Text = "NT:$" + totalP.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("金額為:$" + totalP);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("金額為:$" + totalP * 0.9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            beerQ = 0;
            tequilaQ = 0;
            whiskyQ = 0;
            wineQ = 0;
            totalP = 0;
            txtTotalAmount.Text = "" + totalP;
            list.Text = "您尚未點餐";
        }
        

      

        private void list_TextChanged(object sender, EventArgs e)
        {

        }
        public void show()
        {
            list.Text = "";
            if (beerQ != 0)

                list.Text = "啤酒" + "x" + beerQ + "       " + beerP + Environment.NewLine;

            if (tequilaQ != 0)

                list.Text += "龍舌蘭酒" + "x" + tequilaQ + "       " + tequilaP + Environment.NewLine;

            if (whiskyQ != 0)

                list.Text += "威士忌" + "x" + whiskyQ + "       " + whiskyP + Environment.NewLine;

            if (wineQ != 0)

                list.Text += "紅酒" + "x" + wineQ + "       " + wineP + Environment.NewLine;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    } 
}