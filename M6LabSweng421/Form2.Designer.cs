namespace M6LabSweng421
{
    partial class Form2
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
            button3 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(248, 37);
            button3.Name = "button3";
            button3.Size = new Size(86, 27);
            button3.TabIndex = 7;
            button3.Text = "PrintGraph";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(647, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(132, 37);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 5;
            button2.Text = "UpdateGraph";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 37);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 4;
            button1.Text = "SaveGraph";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(341, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 315);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Please Draw Below Here";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 11;
            textBox2.Text = "Graph Printed Here";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "▼▼▼▼▼▼▼▼▼▼";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 13;
            textBox4.Text = "Please Draw Above Here";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 14;
            textBox5.Text = "▲▲▲▲▲▲▲▲▲▲";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(358, 37);
            button4.Name = "button4";
            button4.Size = new Size(83, 27);
            button4.TabIndex = 15;
            button4.Text = "CopyGraph";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
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
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private ListBox listBox1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button4;
    }
}