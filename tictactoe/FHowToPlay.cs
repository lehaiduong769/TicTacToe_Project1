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
    public partial class FHowToPlay : Form
    {
        public FHowToPlay()
        {
            InitializeComponent();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fmenu = new Menu();
            fmenu.Closed += (s, args) => this.Close();
            fmenu.Show();
        }
    }
}
