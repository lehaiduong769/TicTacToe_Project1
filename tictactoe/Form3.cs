using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace tictactoe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ShowData();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fmenu = new Menu();
            fmenu.Closed += (s, args) => this.Close();
            fmenu.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Stack<string> record = new Stack<string>();
            
        }
        void ShowData()
        {
            string TimeText = "";
            string TurnsPassedText = "";
            string ResultText = "";
            using (StreamReader sr = new StreamReader(@"D:\VTC\8.Project 1\tictactoe\MENACElib\record.txt"))
            {
                while (!sr.EndOfStream)
                {
                    //record.Push(sr.ReadLine());

                    var temp = sr.ReadLine().Split(",");
                    TimeText = temp[0] + "\n" + TimeText;
                    TurnsPassedText = temp[1].Length + "\n" + TurnsPassedText;
                    if (temp[2] == "-") ResultText = "Draw\n" + ResultText;
                    else ResultText = temp[2] + " won\n" + ResultText;
                }
            }
            richTextBox1.Text = TimeText;
            richTextBox2.Text = TurnsPassedText;
            richTextBox3.Text = ResultText;
        }
    }
}
