using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTocToe_Project1
{
    public partial class FHowToPlay : FForm
    {
        public FHowToPlay()
        {
            InitializeComponent();
        }

        private void butMenu_Click(object sender, EventArgs e) => base.button11_Click(sender, e);

        //private void butMenu_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FMenu fmenu = new FMenu();
        //    fmenu.Closed += (s, args) => this.Close();
        //    fmenu.Show();
        //}
    }
}
