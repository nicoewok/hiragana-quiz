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
    public partial class Katakana : Form
    {
        public Katakana(Form1 parent, int katakana)
        {
            InitializeComponent();
            this.parent = parent;
            string[] katakanas = new string[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro", "ya", "yu", "yo", "wa", "wo", "n" };
            solution = katakanas[katakana];
            this.symbol.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "images", "katakana", solution + ".png"));
        }

        private Form1 parent;
        private string solution;


        //Check-button
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == solution)
            {
                parent.add_h_score();
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

        }
    }
}
