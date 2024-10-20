namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private bool isPlayerXTurn = true;
        private int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                button.Text = isPlayerXTurn ? "X" : "O";
                label2.Text = isPlayerXTurn ? "O's Turn" : "X's Turn";
                isPlayerXTurn = !isPlayerXTurn;
                turnCount++;
                CheckForWinner();
            }
        }
        private void CheckForWinner()
        {
            bool winner = false;

            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (btn1.Text != ""))
            {
                winner = true;
            }
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (btn4.Text != ""))
            {
                winner = true;
            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (btn7.Text != ""))
            {
                winner = true;
            }
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (btn1.Text != ""))
            {
                winner = true;
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (btn2.Text != ""))
            {
                winner = true;
            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (btn3.Text != ""))
            {
                winner = true;
            }
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (btn1.Text != ""))
            {
                winner = true;
            }
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (btn3.Text != ""))
            {
                winner = true;
            }
            if (winner)
            {
                DisableButtons();
                string winnerPlayer = isPlayerXTurn ? "O" : "X";
                MessageBox.Show(winnerPlayer + " Wins!", "Game Over");
                ResetGame();
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("it's a draw", "Game Over");
                ResetGame();
            }

        }
        private void DisableButtons()
        {
            foreach (Control control in Controls)
            {
                Button button = control as Button;
                if (button != null)
                {
                    button.Enabled = false;
                }
            }
        }
        private void ResetGame()
        {
            foreach (Control control in Controls)
            {
                Button button = control as Button;
                if (button != null)
                {
                    button.Enabled = true;
                    button.Text = "";
                }
            }
            turnCount = 0;
            isPlayerXTurn = true;
        }       

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkSalmon;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = SystemColors.Control;
        }
    }
}
