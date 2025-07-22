namespace MainForm
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Singleplayer";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Multiplayer";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Mods";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Options";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(412, 279);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "Exit";
            // 
            // button1
            // 
            button1.Location = new Point(240, 99);
            button1.Name = "button1";
            button1.Size = new Size(338, 75);
            button1.TabIndex = 5;
            button1.Text = "Minecraft Logo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(584, 279);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 6;
            button2.Text = "R";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(617, 279);
            button3.Name = "button3";
            button3.Size = new Size(27, 27);
            button3.TabIndex = 7;
            button3.Text = "L";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(665, 388);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 8;
            textBox6.Text = "Copyright";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 388);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 27);
            textBox7.TabIndex = 9;
            textBox7.Text = "Version";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(584, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(158, 24);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "Texts";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minecraft;
            ClientSize = new Size(800, 423);
            Controls.Add(richTextBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox7;
        private RichTextBox richTextBox1;
    }
}
