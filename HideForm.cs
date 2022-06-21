using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe_Project1
{
    internal class HideForm:Form
    {

        protected void HideCurrentForm( Form form)
        {
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
