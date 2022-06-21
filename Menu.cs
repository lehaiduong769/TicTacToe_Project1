namespace TicTocToe_Project1
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();

        }

        private void but1Player_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1Player OnePlayer = new F1Player();
            OnePlayer.Closed += (s, args) => this.Close();
            OnePlayer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHowToPlay fhowtoplay = new FHowToPlay();
            fhowtoplay.Closed += (s, args) => this.Close();
            fhowtoplay.Show();
        }

        private void but2players_Click(object sender, EventArgs e)
        {
            this.Hide();
            F2Players f2players = new F2Players();
            f2players.Closed += (s, args) => this.Close();
            f2players.Show();
        }
    }
}