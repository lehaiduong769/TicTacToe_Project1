using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but1Player_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU PLAY 1ST");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void but2players_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O PLAYS 1ST");
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void butRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void butHWP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHowToPlay fhtp = new FHowToPlay();
            fhtp.Closed += (s, args) => this.Close();
            fhtp.Show();
        }
    }
}
