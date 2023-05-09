namespace WindowsFormsApp2
{
    partial class 猜數字遊戲
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(236, 279);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(144, 56);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "開猜!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGuess.Location = new System.Drawing.Point(227, 197);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(336, 52);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.Location = new System.Drawing.Point(408, 279);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(145, 56);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "我要投降:(";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(183, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入0-100的數:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 猜數字遊戲
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Name = "猜數字遊戲";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.猜數字遊戲_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
    }
}