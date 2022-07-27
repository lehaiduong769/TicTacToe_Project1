using Microsoft.VisualBasic.Devices;
using Timer = System.Windows.Forms.Timer;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        Player currentPlayer; // calling the player class 
        List<Button> buttons; // creating a LIST or array of buttons
        int player1Wins = 0; // set the player 1 win integer to 0
        int player2Wins = 0; // set the player 2 win integer to 0 
        string gameRecord = ""; //record of steps witten in file
        List<byte> currentState = new(); // record of steps passed to AI's MENACE

        // below is the player class which has two value
        // X and O
        // by doing this we can control the player symbols
        public enum Player
        {
            X, O
        }

        public Form2()
        {
            InitializeComponent();
            resetGame();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // this function is linked with the reset button
            // when the reset button is clicked then
            // this function will run the reset game function           
            resetGame();
            player1Wins = 0;
            player2Wins = 0;
            butX.Text = "0";
            but0.Text = "0";
        }
        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // find which button was clicked
            gameRecord += button.TabIndex - 2; //record button player clicked, button starting from 0 to 8
            switchPlayer();
            if (currentPlayer == Player.X) playerX(ref button);
            else playerO(ref button);
            button.Enabled = false; // disable the button
            buttons.Remove(button); //remove the button from the list buttons so the AI can't click it either
            Check(); // check if the player won
        }
        private void switchPlayer() => currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
        private void playerX(ref Button button)
        {
            button.Text = "X";
            button.BackColor = System.Drawing.Color.White; // change the player colour to Cyan
        }
        private void playerO(ref Button button)
        {
            button.Text = "O";
            button.BackColor = System.Drawing.Color.DarkSalmon; // change the player colour to Violet
        }
        private void loadbuttons()
        {
            // this the custom function which will load all the buttons from the form to the buttons list
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }

        private void resetGame()
        {
            //check each of the button with a tag of play
            foreach (Control X in panel2.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors
                }
            }
            currentState = new();
            gameRecord = "";
            loadbuttons(); // run the load buttons function so all the buttons are inserted back in the array
        }
        private void Record(string winner)
        {
            using (StreamWriter sw = File.AppendText(@"D:\VTC\8.Project 1\tictactoe\MENACElib\record.txt"))
            {
                sw.WriteLine($"{DateTime.Now},{gameRecord},{winner}");
            }
            using (StreamWriter sw = new(@"D:\VTC\8.Project 1\tictactoe\MENACElib\tempRecord.txt"))
            {
                sw.WriteLine($"{DateTime.Now},{gameRecord},{winner}");
            }
        }
        private void Check()
        {
            //in this function we will check if the player or the AI has won
            // we have two very large if statements with the winning possibilities
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // if any of the above conditions are met
                MessageBox.Show("X WIN !!!"); // show a message to the player
                player1Wins++; // increase the player wins                 
                butX.Text = Convert.ToString(player1Wins); // update player label
                Record("X");
                resetGame(); // run the reset game function
            }
            // below if statement is for when the Player 2 wins the game
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                // if any of the conditions are met above then we will do the following
                // this code will run when the player 2 wins the game
                MessageBox.Show("O WIN !!!"); // show a message box to say player O won
                player2Wins++; // increase the computer wins score number                
                but0.Text = Convert.ToString(player2Wins); // update the label 0 wins
                Record("O");
                resetGame(); // run the reset game
            }
            else if (buttons.Count==0)
            {
                MessageBox.Show("Draw !!!");
                Record("-");
                resetGame();
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}