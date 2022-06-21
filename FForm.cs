using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe_Project1
{
    public class FForm : Form
    {
        protected void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu fmenu = new FMenu();
            fmenu.Closed += (s, args) => this.Close();
            fmenu.Show();
        }
    }
}
