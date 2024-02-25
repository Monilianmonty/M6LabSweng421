namespace M6LabSweng421
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 29);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 0;
            button1.Text = "SaveGraph";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(160, 29);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 1;
            button2.Text = "UpdateGraph";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(644, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(294, 27);
            button3.Name = "button3";
            button3.Size = new Size(86, 27);
            button3.TabIndex = 3;
            button3.Text = "PrintGraph";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(419, 27);
            button4.Name = "button4";
            button4.Size = new Size(83, 27);
            button4.TabIndex = 26;
            button4.Text = "CopyGraph";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(93, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 25;
            textBox5.Text = "▲▲▲▲▲▲▲▲▲▲";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(74, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 24;
            textBox4.Text = "Please Draw Above Here";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 23;
            textBox3.Text = "▼▼▼▼▼▼▼▼▼▼";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 22;
            textBox2.Text = "Graph Printed Here";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 21;
            textBox1.Text = "Please Draw Below Here";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(308, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 315);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}