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
            textBoxSingleplayer = new TextBox();
            textBoxMultiplayer = new TextBox();
            textBoxMods = new TextBox();
            textBoxOptions = new TextBox();
            textBoxQuit = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            logoButton = new Button();
            button2 = new Button();
            button3 = new Button();
            textMojang = new TextBox();
            textVersion = new TextBox();
            richTextBoxSplashes = new RichTextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBoxSingleplayer
            // 
            textBoxSingleplayer.Location = new Point(240, 180);
            textBoxSingleplayer.Name = "textBoxSingleplayer";
            textBoxSingleplayer.Size = new Size(338, 27);
            textBoxSingleplayer.TabIndex = 0;
            textBoxSingleplayer.Text = "Singleplayer";
            // 
            // textBoxMultiplayer
            // 
            textBoxMultiplayer.Location = new Point(240, 213);
            textBoxMultiplayer.Name = "textBoxMultiplayer";
            textBoxMultiplayer.Size = new Size(338, 27);
            textBoxMultiplayer.TabIndex = 1;
            textBoxMultiplayer.Text = "Multiplayer";
            // 
            // textBoxMods
            // 
            textBoxMods.Location = new Point(240, 246);
            textBoxMods.Name = "textBoxMods";
            textBoxMods.Size = new Size(338, 27);
            textBoxMods.TabIndex = 2;
            textBoxMods.Text = "Mods";
            // 
            // textBoxOptions
            // 
            textBoxOptions.Location = new Point(240, 279);
            textBoxOptions.Name = "textBoxOptions";
            textBoxOptions.Size = new Size(166, 27);
            textBoxOptions.TabIndex = 3;
            textBoxOptions.Text = "Options";
            // 
            // textBoxQuit
            // 
            textBoxQuit.Location = new Point(412, 279);
            textBoxQuit.Name = "textBoxQuit";
            textBoxQuit.Size = new Size(166, 27);
            textBoxQuit.TabIndex = 4;
            textBoxQuit.Text = "Exit";
            // 
            // logoButton
            // 
            logoButton.BackgroundImageLayout = ImageLayout.Stretch;
            logoButton.Location = new Point(240, 99);
            logoButton.Name = "logoButton";
            logoButton.Size = new Size(338, 75);
            logoButton.TabIndex = 5;
            logoButton.Text = "Minecraft Logo";
            logoButton.UseVisualStyleBackColor = true;
            logoButton.Click += logoButton_Click;
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
            button3.Click += button3_Click;
            // 
            // textMojang
            // 
            textMojang.Location = new Point(665, 388);
            textMojang.Name = "textMojang";
            textMojang.Size = new Size(125, 27);
            textMojang.TabIndex = 8;
            textMojang.Text = "Copyright";
            // 
            // textVersion
            // 
            textVersion.Location = new Point(12, 388);
            textVersion.Name = "textVersion";
            textVersion.Size = new Size(174, 27);
            textVersion.TabIndex = 9;
            textVersion.Text = "Version";
            // 
            // richTextBoxSplashes
            // 
            richTextBoxSplashes.Location = new Point(584, 68);
            richTextBoxSplashes.Name = "richTextBoxSplashes";
            richTextBoxSplashes.Size = new Size(158, 24);
            richTextBoxSplashes.TabIndex = 10;
            richTextBoxSplashes.Text = "Texts";
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(112, 55);
            button4.TabIndex = 11;
            button4.Text = "Background";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minecraft;
            ClientSize = new Size(800, 423);
            Controls.Add(button4);
            Controls.Add(richTextBoxSplashes);
            Controls.Add(textVersion);
            Controls.Add(textMojang);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(logoButton);
            Controls.Add(textBoxQuit);
            Controls.Add(textBoxOptions);
            Controls.Add(textBoxMods);
            Controls.Add(textBoxMultiplayer);
            Controls.Add(textBoxSingleplayer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSingleplayer;
        private TextBox textBoxMultiplayer;
        private TextBox textBoxMods;
        private TextBox textBoxOptions;
        private TextBox textBoxQuit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button logoButton;
        private Button button2;
        private Button button3;
        private TextBox textMojang;
        private TextBox textVersion;
        private RichTextBox richTextBoxSplashes;
        private Button button4;
    }
}
