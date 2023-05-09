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
    public partial class 陣列2 : Form
    {
        public 陣列2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number)) // 檢查輸入是否為整數
            {
                if (number % 2 == 1) // 判斷是否為奇數
                {
                    MessageBox.Show(number + "是奇數");
                }
                else
                {
                    MessageBox.Show(number + "是偶數");
                }
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) // 判斷是否為偶數
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            label3.Text = "陣列A[]統計奇偶數[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
            "偶數數量:" + evenCount + "\n" +
            "奇數數量:" + oddCount;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {

            string[] names = { "安海瑟威", "喬治勒隆尼", "西恩潘", "希斯萊傑" };
            string longestName = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                if (names[i].Length > longestName.Length)
                {
                    longestName = names[i];
                }
            }
            label3.Text = "陣列A[]最長的名字[安海瑟威, 喬治勒隆尼, 西恩潘, 希斯萊傑]" + "\n" +
            "最長的名字為:" + longestName;

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int MaxNum = numbers.Max();
            int MinNum = numbers.Min();
            label3.Text = "陣列A[]最大/小的值[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "最大值為:" + MaxNum + "\n" +
                "最小值為:" + MinNum;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string matrixString = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j].ToString() + " ";
                }

                matrixString += "\n";
            }

            label3.Text = matrixString;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            string matrixString = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j].ToString() + " ";
                }

                matrixString += "\n";
            }

            label3.Text = matrixString;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int[,] myArray = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 2 == 0)
                    {
                        myArray[i, j] = (j % 2 == 0) ? 1 : 0;
                    }
                    else
                    {
                        myArray[i, j] = (j % 2 == 0) ? 0 : 1;
                    }
                }
            }

            string outputString = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    outputString += myArray[i, j].ToString() + " ";
                }
                outputString += "\n";
            }

            label3.Text = outputString;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label3.Text = "換位前n1=100,n2=200\n換位後n1=200,n2=100";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Sum = numbers.Sum();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "內的和為" + Sum.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Max = numbers.Max();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "內的最大值為" + Max.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Min = numbers.Min();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "最大值為:" + Min.ToString();

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string[] myArray = { "APPLE", "BEER", "LAB", "CAR" };
            char searchChar = 'A';

            int count = myArray.Count(str => str.Contains(searchChar));

            label3.Text = "陣列A[APPLE, BEER, LAB, CAR]" + "\n" +
            string.Format("The number of words containing '{0}' is {1}", searchChar, count);

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            label3.Text = "ANSWER";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string aStr = textBox2.Text;
            string bStr = textBox3.Text;
            string cStr = textBox4.Text;
             
          
            if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b) || !int.TryParse(cStr, out int c))
            {              
                MessageBox.Show("請輸入數字");
            }
            else
            {       
                int sum = 0;
                for (int i = a; i <= b; i += c)
                {
                    sum += i;
                }
                label3.Text = "使用for迴圈:" + "\n" + a + "到" + b + "相隔" + c + "相加總合等於:" + sum.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string aStr = textBox2.Text;
            string bStr = textBox3.Text;
            string cStr = textBox4.Text;


            if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b) || !int.TryParse(cStr, out int c))
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                int i = 0;
                int sum = 0;
                while (i <= b)
                {
                    sum += i;  // 將 i 加到總和中
                    i += c;  // i 加上間隔數字 c
                }
                label3.Text = "使用while迴圈:" + "\n" + a + "到" + b + "相隔" + c + "相加總合等於:" + sum.ToString();


                //label3.Text = "使用while迴圈:" + "\n" + a + "到" + b + "相隔" + c + "相加總合等於:" + sum.ToString();
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            string aStr = textBox2.Text;
            string bStr = textBox3.Text;
            string cStr = textBox4.Text;


            if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b) || !int.TryParse(cStr, out int c))
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                int i = 0;
                int sum = 0;
                do
                {
                    sum += a;
                    a += c;
                } while (a <= b);
                label3.Text = "使用do迴圈:" + "\n" + a + "到" + b + "相隔" + c + "相加總合等於:" + sum.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void 陣列2_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int height = int.Parse(textBox5.Text);

            string result = "";
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";
                }
                result += "\n";
            }

            label3.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string[] names = { "安海瑟威", "喬治勒隆尼", "西恩潘", "希斯萊傑" };
            string longestName = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                if (names[i].Length > longestName.Length)
                {
                    longestName = names[i];
                }
            }
            label3.Text = "陣列A[]最長的名字[安海瑟威, 喬治勒隆尼, 西恩潘, 希斯萊傑]" + "\n" +
            "最長的名字為:" + longestName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int MaxNum = numbers.Max();
            int MinNum = numbers.Min();
            label3.Text = "陣列A[]最大/小的值[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "最大值為:" + MaxNum + "\n" +
                "最小值為:" + MinNum;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] myArray = { "APPLE", "BEER", "LAB", "CAR" };
            char searchChar = 'A';

            int count = myArray.Count(str => str.Contains(searchChar));

            label3.Text = "陣列A[APPLE, BEER, LAB, CAR]" + "\n" +
            string.Format("The number of words containing '{0}' is {1}", searchChar, count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string matrixString = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j].ToString() + " ";
                }

                matrixString += "\n";
            }

            label3.Text = matrixString;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            string matrixString = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j].ToString() + " ";
                }

                matrixString += "\n";
            }

            label3.Text = matrixString;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] myArray = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 2 == 0)
                    {
                        myArray[i, j] = (j % 2 == 0) ? 1 : 0;
                    }
                    else
                    {
                        myArray[i, j] = (j % 2 == 0) ? 0 : 1;
                    }
                }
            }

            string outputString = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    outputString += myArray[i, j].ToString() + " ";
                }
                outputString += "\n";
            }

            label3.Text = outputString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "換位前n1=100,n2=200\n換位後n1=200,n2=100";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Sum = numbers.Sum();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "內的和為" + Sum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Max = numbers.Max();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "內的最大值為" + Max.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] numbers = { 265, 562, 12, 95, 135, 541, 26, 446, 15, 7 };
            int Min = numbers.Min();
            label3.Text = "陣列A[265, 562, 12, 95, 135, 541, 26, 446, 15, 7]" + "\n" +
                "最大值為:" + Min.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    result += $"{i}x{j}={i * j}" + "|";
                    
                }
                result += "\n";
            }

            label3.Font = new Font("Consolas", 10f);
            label3.Text = result;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label3.Text =  "1100100";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            HashSet<int> set = new HashSet<int>();
            while (set.Count < 6)
            {
                set.Add(random.Next(1, 51));
            }

            string result = string.Join(" ", set);
            label3.Text ="樂透號碼:"+"\n"+"["+result+"]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number)) // 檢查輸入是否為整數
            {
                if (number % 2 == 1) // 判斷是否為奇數
                {
                    MessageBox.Show(number + "是奇數");
                }
                else
                {
                    MessageBox.Show(number + "是偶數");
                }
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
   
 