namespace WindowsFormsApp2
{
    partial class 收銀機
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(收銀機));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(32, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 118);
            this.button1.TabIndex = 0;
            this.button1.Text = "啤酒\r\nBeer\r\nNT$120";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(130, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(32, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 123);
            this.button3.TabIndex = 2;
            this.button3.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(130, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 123);
            this.button4.TabIndex = 3;
            this.button4.Text = "紅酒\r\nWine\r\nNT$320";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 362);
            this.label1.TabIndex = 4;
            this.label1.Text = "菜單";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(271, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 112);
            this.label2.TabIndex = 5;
            this.label2.Text = "總金額";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(271, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 113);
            this.label3.TabIndex = 6;
            this.label3.Text = "付款方式";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "現金";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(410, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "信用卡";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(547, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 361);
            this.label4.TabIndex = 9;
            this.label4.Text = "購物清單";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(685, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 42);
            this.button7.TabIndex = 12;
            this.button7.Text = "清除清單";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalAmount.Location = new System.Drawing.Point(303, 106);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(192, 29);
            this.txtTotalAmount.TabIndex = 14;
            this.txtTotalAmount.Text = "NT$0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // list
            // 
            this.list.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.list.Location = new System.Drawing.Point(560, 59);
            this.list.Multiline = true;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(216, 269);
            this.list.TabIndex = 13;
            this.list.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.list.TextChanged += new System.EventHandler(this.list_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(408, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "信用卡付款打9折";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // 收銀機
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "收銀機";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox list;
        private System.Windows.Forms.Label label5;
    }
}