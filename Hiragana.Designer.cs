﻿namespace hiragana_quiz
{
    partial class Hiragana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hiragana));
            symbol = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)symbol).BeginInit();
            SuspendLayout();
            // 
            // symbol
            // 
            symbol.InitialImage = (Image)resources.GetObject("symbol.InitialImage");
            symbol.Location = new Point(276, 12);
            symbol.Name = "symbol";
            symbol.Size = new Size(256, 256);
            symbol.TabIndex = 0;
            symbol.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(365, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 271);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "This is:";
            // 
            // button2
            // 
            button2.Location = new Point(700, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Next ->";
            button2.UseVisualStyleBackColor = true;
            // 
            // Hiragana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(symbol);
            Name = "Hiragana";
            Text = "Hiragana";
            ((System.ComponentModel.ISupportInitialize)symbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox symbol;

        

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}