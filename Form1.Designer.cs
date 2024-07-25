namespace hiragana_quiz
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
            hiragana_score_lbl = new Label();
            katakana_score_lbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(200, 74);
            button1.Name = "button1";
            button1.Size = new Size(150, 75);
            button1.TabIndex = 0;
            button1.Text = "Hiragana";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 244);
            button2.Name = "button2";
            button2.Size = new Size(150, 75);
            button2.TabIndex = 1;
            button2.Text = "Katakana";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hiragana_score_lbl
            // 
            hiragana_score_lbl.AutoSize = true;
            hiragana_score_lbl.Location = new Point(200, 162);
            hiragana_score_lbl.Name = "hiragana_score_lbl";
            hiragana_score_lbl.Size = new Size(62, 15);
            hiragana_score_lbl.TabIndex = 2;
            hiragana_score_lbl.Text = "Top scores";
            // 
            // katakana_score_lbl
            // 
            katakana_score_lbl.AutoSize = true;
            katakana_score_lbl.Location = new Point(200, 331);
            katakana_score_lbl.Name = "katakana_score_lbl";
            katakana_score_lbl.Size = new Size(62, 15);
            katakana_score_lbl.TabIndex = 3;
            katakana_score_lbl.Text = "Top scores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 411);
            Controls.Add(katakana_score_lbl);
            Controls.Add(hiragana_score_lbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label hiragana_score_lbl;
        private Label katakana_score_lbl;
    }
}
