using System.Windows.Forms;

namespace TDD4
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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            textBox7 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Radius";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 54);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 1;
            button1.Text = "Add Circle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(658, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(148, 244);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "Height";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            textBox3.Text = "Width";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(197, 96);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 5;
            button2.Text = "Add Rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(377, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 27);
            textBox4.TabIndex = 6;
            textBox4.Text = "Base";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(377, 54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 27);
            textBox5.TabIndex = 7;
            textBox5.Text = "Height";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(377, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 27);
            textBox6.TabIndex = 8;
            textBox6.Text = "Width";
            // 
            // button3
            // 
            button3.Location = new Point(377, 139);
            button3.Name = "button3";
            button3.Size = new Size(139, 29);
            button3.TabIndex = 9;
            button3.Text = "Add Paralelogram";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(628, 323);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 10;
            label1.Text = "Characteristics:";
            label1.Click += label1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(728, 280);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 11;
            textBox7.Text = "Index";
            // 
            // button4
            // 
            button4.Location = new Point(628, 278);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 228);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 13;
            button5.Text = "Information";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(159, 228);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(23, 303);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 15;
            label2.Text = "Data";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(865, 556);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Shape Manager";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button3;
        private Label label1;
        private TextBox textBox7;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private Label label2;
    }
}
