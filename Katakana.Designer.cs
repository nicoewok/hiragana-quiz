﻿namespace hiragana_quiz
{
    partial class Katakana
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            symbol = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            score_lbl = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)symbol).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(245, 350);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 295);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "This is:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // symbol
            // 
            symbol.Location = new Point(172, 15);
            symbol.Name = "symbol";
            symbol.Size = new Size(256, 256);
            symbol.TabIndex = 3;
            symbol.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(450, 350);
            button2.Name = "button2";
            button2.Size = new Size(110, 60);
            button2.TabIndex = 4;
            button2.Text = "Next ->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(450, 415);
            button3.Name = "button3";
            button3.Size = new Size(110, 25);
            button3.TabIndex = 5;
            button3.Text = "Quit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.Location = new Point(450, 323);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(81, 15);
            score_lbl.TabIndex = 6;
            score_lbl.Text = "Current score:";
            // 
            // button4
            // 
            button4.Location = new Point(245, 415);
            button4.Name = "button4";
            button4.Size = new Size(110, 25);
            button4.TabIndex = 7;
            button4.Text = "Show correct";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Katakana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(button4);
            Controls.Add(score_lbl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(symbol);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Katakana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Katakana";
            ((System.ComponentModel.ISupportInitialize)symbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private PictureBox symbol;
        private Button button2;
        private Button button3;
        private Label score_lbl;
        private Button button4;
    }
}