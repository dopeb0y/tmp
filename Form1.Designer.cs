namespace CombinatorialProblem
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(10, 83);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(127, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(10, 29);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(127, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 450);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(15, 406);
            label5.Name = "label5";
            label5.Size = new Size(118, 39);
            label5.TabIndex = 5;
            label5.Text = "Графическое \r\nотображение \r\nдоступно при m < 11";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 203);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(10, 166);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 6;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(10, 109);
            label3.Name = "label3";
            label3.Size = new Size(127, 45);
            label3.TabIndex = 3;
            label3.Text = "Число лунок должно \r\nбыть больше числа \r\nшаров!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите число шаров";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите число лунок";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(155, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(664, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(825, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 450);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 459);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Определение числа размещений по лункам";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
    }
}