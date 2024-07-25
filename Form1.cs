namespace hiragana_quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int hiragana_score = 0;
        public int katakana_score = 0;

        private Hiragana hiragana;
        private Katakana katakana;

        public void add_h_score()
        {
            hiragana_score++;
            hiragana_score_lbl.Text = "Current score: " + hiragana_score.ToString();
        }

        public int get_h_score()
        {
            return hiragana_score;
        }

        public void add_k_score()
        {
            katakana_score++;
            katakana_score_lbl.Text = "Current score: " + katakana_score.ToString();
        }

        public int get_k_score()
        {
            return katakana_score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hiragana_score_lbl.Text = "Current score: " + hiragana_score.ToString();
            katakana_score_lbl.Text = "Current score: " + katakana_score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spawn_hiragana();
        }

        public void spawn_hiragana()
        {
            if (hiragana != null)
            {
                hiragana.Close();
                hiragana.Dispose();
            }

            //select hiragana randomly and spawn new form
            Random rnd = new Random();
            int random = rnd.Next(0, 45);
            hiragana = new Hiragana(this, random);
            hiragana.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            spawn_katakana();
        }

        public void spawn_katakana()
        {
            if (katakana != null)
            {
                katakana.Close();
                katakana.Dispose();
            }

            //select katakana randomly and spawn new form
            Random rnd = new Random();
            int random = rnd.Next(0, 47);
            katakana = new Katakana(this, random);
            katakana.Show();
        }
    }
}
