using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiragana_quiz
{
    public partial class Hiragana : Form
    {

        private Form1 parent;
        private string solution;

        public Hiragana(Form1 parent, int hiragana)
        {
            InitializeComponent();
            this.parent = parent;
            this.score_lbl.Text = "Current score: " + parent.get_h_score();

            string[] hiraganas = new string[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "ya", "yu", "yo", "wa", "wo", "n" };
            solution = hiraganas[hiragana];
            this.symbol.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "images", "hiragana", solution + ".png"));

        }

        //Check-button
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == solution)
            {
                this.button1.Enabled = false;
                parent.add_h_score();
                this.score_lbl.Text = "Current score: " + parent.get_h_score();
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect, try again");
            }
        }

        //Next-button
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 45);
            Hiragana next = new Hiragana(this.parent, random);
            next.Show();
            this.Close();
            this.Dispose();
        }

        //Quit-button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show-button
        private void button4_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            MessageBox.Show(solution);
        }
    }
}
