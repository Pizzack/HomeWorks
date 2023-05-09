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
    public partial class 猜數字遊戲 : Form
    {
        public 猜數字遊戲()
        {
            InitializeComponent();
        }
        private int targetNumber; // 遊戲目標數字
        private int guessCount; // 玩家猜測次數

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 猜數字遊戲_Load(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guessNumber;

            // 判斷玩家輸入的是否為正確的數字
            if (!int.TryParse(txtGuess.Text, out guessNumber))
            {
                MessageBox.Show("請輸入有效的數字。");
                return;
            }

            // 更新猜測次數
            guessCount++;

            // 判斷玩家猜測的數字是否等於目標數字
            if (guessNumber == targetNumber)
            {
                MessageBox.Show($"恭喜你，猜中了！你總共猜了 {guessCount} 次。");
                StartNewGame(); // 開始新遊戲
            }
            else if (guessNumber < targetNumber)
            {
                MessageBox.Show("你猜的數字太小了，再試試。");
            }
            else
            {
                MessageBox.Show("你猜的數字太大了，再試試。");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame(); // 重新開始遊戲
        }
        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101); // 隨機產生 1 到 100 的數字
            guessCount = 0; // 重置猜測次數
            txtGuess.Text = ""; // 清空輸入框
            txtGuess.Focus(); // 讓輸入框獲得焦點
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
