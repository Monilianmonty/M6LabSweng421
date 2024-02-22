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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 41);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 0;
            button1.Text = "SaveGraph";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 43);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 1;
            button2.Text = "Clear";
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
            button3.Location = new Point(302, 41);
            button3.Name = "button3";
            button3.Size = new Size(86, 27);
            button3.TabIndex = 3;
            button3.Text = "CreateGraph";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
    }
}