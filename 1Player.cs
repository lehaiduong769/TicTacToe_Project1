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
    public partial class F1Player : FForm
    {
        public F1Player()
        {
            InitializeComponent();
            //CreateChessBoard();
        }

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FMenu Menu = new FMenu();
        //    Menu.Closed += (s, args) => this.Close();
        //    Menu.Show();
        //}
        void CreateChessBoard()
        {
            Button PreButton = new Button() { Width = 88, Height = 88, Location = new Point(566, 164) };
            for (int i = 0; i < ChessBoard.ChessBoardHeight; i++)
            {
                for (int j = 0; j < ChessBoard.ChessBoardWidth; j++)
                {
                    Button btn = new Button() { Width = ChessBoard.BoxWidth, Height = ChessBoard.BoxHeight, Location = new Point(PreButton.Location.X + PreButton.Width, PreButton.Location.Y) };
                    this.Controls.Add(btn);
                    PreButton = btn;
                }
                PreButton.Location = new Point(566, PreButton.Location.Y + ChessBoard.BoxHeight);
                PreButton.Width = 88;
                PreButton.Height = 88;    
            }
        }
    }
}
