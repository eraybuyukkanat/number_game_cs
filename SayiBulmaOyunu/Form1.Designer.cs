namespace SayiBulmaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            Tahminler = new ListBox();
            Sonuçlar = new ListBox();
            label7 = new Label();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 21);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(103, 50);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(161, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(103, 79);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(161, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Gizli Sayı =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Hak Sayısı =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 81);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Süre =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 83);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "(Saniye)";
            // 
            // button1
            // 
            button1.Location = new Point(273, 21);
            button1.Name = "button1";
            button1.Size = new Size(117, 59);
            button1.TabIndex = 7;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 125);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 8;
            label5.Text = "Basamak Sayısı: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 242);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 9;
            label6.Text = "Tahmini Sayı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(318, 247);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Tahmin Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 426);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 16;
            label9.Text = "Kalan Hak Sayısı =";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(187, 426);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 17;
            label10.Text = "Kalan Süre =";
            // 
            // Tahminler
            // 
            Tahminler.FormattingEnabled = true;
            Tahminler.ItemHeight = 15;
            Tahminler.Location = new Point(449, 50);
            Tahminler.Name = "Tahminler";
            Tahminler.Size = new Size(125, 199);
            Tahminler.TabIndex = 19;
            // 
            // Sonuçlar
            // 
            Sonuçlar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Sonuçlar.FormattingEnabled = true;
            Sonuçlar.Location = new Point(580, 50);
            Sonuçlar.Name = "Sonuçlar";
            Sonuçlar.Size = new Size(214, 199);
            Sonuçlar.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(468, 19);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 21;
            label7.Text = "Tahminler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(632, 19);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 22;
            label8.Text = "Sonuçlar";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(33, 289);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(733, 100);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Sonuçlar);
            Controls.Add(Tahminler);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button2;
        private Label label9;
        private Label label10;
        private ListBox Tahminler;
        private ListBox Sonuçlar;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}