using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Button[,] mybtns;
        int ply;
        public Form1()
        {
            InitializeComponent();

             mybtns = new Button[3, 3] { { button1,button2,button3},
                                          {button4,button5,button6 },
                                          {button7,button8,button9 }};

            new_game();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.DarkBlue;
                    this_button.ForeColor = Color.White;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.DarkRed;
                    this_button.ForeColor = Color.White;
                    ply = 1;
                }

                check_game();
            }
        }
        private void button9_MouseHover(object sender, EventArgs e)
        {
            //Button this_button = (sender as Button);
            //this_button.BackColor = Color.DarkBlue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
           // Button this_button = (sender as Button);
           // this_button.BackColor = Color.SkyBlue;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            new_game();
        }

        private void new_game()
        {
            ply = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mybtns[i, j].Text = "";
                    mybtns[i, j].BackColor = Color.Transparent;
                }
            }
        }

        private void check_game()
        {
            if(mybtns[0,0].Text=="X" && mybtns[0, 1].Text == "X" && mybtns[0, 2].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[1, 0].Text == "X" && mybtns[1, 1].Text == "X" && mybtns[1, 2].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[2, 0].Text == "X" && mybtns[2, 1].Text == "X" && mybtns[2, 2].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[0, 0].Text == "X" && mybtns[1, 0].Text == "X" && mybtns[2, 0].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[0, 1].Text == "X" && mybtns[1, 1].Text == "X" && mybtns[2, 1].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[0, 2].Text == "X" && mybtns[1, 2].Text == "X" && mybtns[2, 2].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[0, 0].Text == "X" && mybtns[1, 1].Text == "X" && mybtns[2, 2].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }
            if (mybtns[0, 2].Text == "X" && mybtns[1, 1].Text == "X" && mybtns[2, 0].Text == "X")
            {
                MessageBox.Show("Player One Wins !");
                new_game();
            }


            if (mybtns[0, 0].Text == "O" && mybtns[0, 1].Text == "O" && mybtns[0, 2].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[1, 0].Text == "O" && mybtns[1, 1].Text == "O" && mybtns[1, 2].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[2, 0].Text == "O" && mybtns[2, 1].Text == "O" && mybtns[2, 2].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[0, 0].Text == "O" && mybtns[1, 0].Text == "O" && mybtns[2, 0].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[0, 1].Text == "O" && mybtns[1, 1].Text == "O" && mybtns[2, 1].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[0, 2].Text == "O" && mybtns[1, 2].Text == "O" && mybtns[2, 2].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[0, 0].Text == "O" && mybtns[1, 1].Text == "O" && mybtns[2, 2].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            if (mybtns[0, 2].Text == "O" && mybtns[1, 1].Text == "O" && mybtns[2, 0].Text == "O")
            {
                MessageBox.Show("Player Two Wins !");
                new_game();
            }
            else if (mybtns[0, 0].Text != "" && mybtns[0, 1].Text != "" && mybtns[0, 2].Text != "" && mybtns[1, 0].Text != "" && mybtns[1, 1].Text != "" && mybtns[1, 2].Text != "" && mybtns[2, 0].Text != "" && mybtns[2, 1].Text != "" && mybtns[2, 2].Text != "")
            {
                MessageBox.Show("Equalized");
                new_game();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

