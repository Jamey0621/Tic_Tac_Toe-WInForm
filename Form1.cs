using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool Turn = true; // true is X turn False is O Turn
        int turnCount = 0; // after 9 turns its a draw

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Name is Jamey, this is a simple game of tic tac toe! ");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {   // this will set the to a click event to display x&o
            // i need to disable the button after the click event
            Button b = (Button)sender;
            if(Turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            Turn = !Turn;
            // disable the button after the click event
            b.Enabled = false;
            turnCount++;


            showAWinner();
        }

        private void showAWinner()
        {
            bool thereIsAWinner = false;
                // logic for the ruels 
                // hor check
            if( (A1.Text == A2.Text && A2.Text == A3.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
           else if ((B1.Text == B2.Text && B2.Text == B3.Text)&& (!B1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((C1.Text == C2.Text && C2.Text == C3.Text) && (!C1.Enabled))
            {
                thereIsAWinner = true;
            }
            // vertical 
            if ((A1.Text == B1.Text && B1.Text == C1.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A2.Text == B2.Text && B2.Text == C2.Text) && (!B1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A3.Text == B3.Text && B3.Text == C3.Text) && (!C1.Enabled))
            {
                thereIsAWinner = true;
            }

            // criss cross
            if ((A1.Text == B2.Text && B2.Text == C3.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A3.Text == B2.Text && B2.Text == C1.Text) && (!B1.Enabled))
            {
                thereIsAWinner = true;
            }
         







            if (thereIsAWinner)
            {
                string winner = "";
                if (Turn)
                { winner = "O"; }
                else 
                { winner = "X"; }
                MessageBox.Show(winner + "WINS!!");
                disableButtons();
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!!!");
                }
            }


            
           

            
        }

        private void disableButtons ()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turn = true;
            turnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "_";
                }
            }
            catch { }


        }
    }
    
    
}
