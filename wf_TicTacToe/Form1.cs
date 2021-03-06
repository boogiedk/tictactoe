﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace wf_TicTacToe
	{
	public partial class Form1 : Form
		{
		bool turn = true; // true = X turn; false = Y turn;
		int turn_count = 0;
		static String player1, player2;
		static bool against_computer = false;

		public Form1()
			{
			InitializeComponent();
			}

		public static void setPlayersNames(String n1, String n2)
			{
			player1 = n1;
			player2 = n2;
			}
		private void setDefaultNamesPlayers()
			{
			if (player1 == "")
				{
				player1 = "X win";
				}
			if (player2 == "")
				{
				player2 = "O win";
				}
			}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
			{
			MessageBox.Show("BOOGIE INC (c) 2017", "TicTacToe About");
			}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
			{
			Application.Exit();
			}

		private void button_click(object sender, EventArgs e)
			{
			Button b = (Button)sender;
			if (turn)
				b.Text = "X";
			else
				b.Text = "O";

			turn = !turn;
			b.Enabled = false;
			turn_count++;

			checkForWinner();

			if ((!turn) && (against_computer))
				{
				computer_make_move();
				}
			}

		public static void get_against_computer(bool ready_bot)
			{
			against_computer = ready_bot;
			}

		private void computer_make_move() // bot
			{
			Button move = null;

			move = look_for_win_or_block("O"); // look for win
			if (move == null)
				{
				move = look_for_win_or_block("X"); // look for block
				if (move == null)
					{
					move = look_for_corner();
					if (move == null)
						{
						move = look_for_open_space();
						}// if
					}//if
				}//if

			move.PerformClick();
			}

		private Button look_for_corner()
			{
			Console.WriteLine("Looking for corner");
			if (A1.Text == "O")
				{
				if (A3.Text == "")
					return A3;
				if (C3.Text == "")
					return C3;
				if (C1.Text == "")
					return C1;
				}

			if (A3.Text == "O")
				{
				if (A1.Text == "")
					return A1;
				if (C3.Text == "")
					return C3;
				if (C1.Text == "")
					return C1;
				}

			if (C3.Text == "O")
				{
				if (A1.Text == "")
					return A1;
				if (A3.Text == "")
					return A3;
				if (C1.Text == "")
					return C1;
				}

			if (A1.Text == "O")
				{
				if (A1.Text == "")
					return A3;
				if (A3.Text == "")
					return A3;
				if (C3.Text == "")
					return C3;
				}

			if (A1.Text == "")
				return A1;
			if (A3.Text == "")
				return A3;
			if (C1.Text == "")
				return C1;
			if (C3.Text == "")
				return C3;

			return null;
			}
		private Button look_for_open_space()
			{
			Console.WriteLine("Looking for open space");
			Button b = null;
			foreach (Control c in Controls)
				{
				b = c as Button;
				if (b != null)
					{
					if (b.Text == "")
						return b;
					}
				}
			return null;

			}

		private Button look_for_win_or_block(string mark)
			{
			Console.WriteLine("Looking for win or block: " + mark);
			//HORIZONTAL TESTS
			if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
				return A3;
			if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
				return A1;
			if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
				return A2;
			//
			if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
				return B3;
			if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
				return B1;
			if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
				return B2;
			//
			if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
				return C3;
			if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
				return C1;
			if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
				return C2;


			//VERTICAL TESTS
			if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
				return C1;
			if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
				return A1;
			if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
				return B1;
			//
			if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
				return C2;
			if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
				return A2;
			if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
				return B2;
			//
			if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
				return C3;
			if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
				return A3;
			if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
				return B3;

			//DIAGONAL TESTS
			if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
				return C3;
			if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
				return A1;
			if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
				return B2;

			if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
				return C1;
			if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
				return A3;
			if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
				return B2;

			return null;
			}

		private void checkForWinner()
			{
			bool there_is_a_winner = false;


			//Horizontal checks
			if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
				there_is_a_winner = true;
			else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
				there_is_a_winner = true;

			//Vertical checks
			else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
				there_is_a_winner = true;
			else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
				there_is_a_winner = true;

				//diagonal checks
			else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
				there_is_a_winner = true;


	
			if (there_is_a_winner)
				{

				disableButtons();
				
			
				string winner = "";
				if (turn)
					{
					winner = player2;
					o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
					}
				else
					{
					winner = player1;
					x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
					}

				if (player1 == "" || player2 == "")
					{
					player1 = "X";
					player2 = "O";
					}
				else
					MessageBox.Show(winner + " Wins!", "Congratulations!");
				newGame();
				} // end if
			else
				{
				if (turn_count == 9)
					{
					draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
					MessageBox.Show("Draw!");
					newGame();
					}
				}
			}//end checkForWinner

		public void newGame()
			{
			turn = true;
			turn_count = 0;

			foreach (Control c in Controls)
				{
				try
					{
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
					}//end try

				catch { }
				}//end foreach
			}// end new game

		private void disableButtons()
			{
			foreach (Control c in Controls)
				{
				try
					{
					Button b = (Button)c;
					b.Enabled = false;
					}//end try
				catch { }
				}// end foreach
			}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
			{
			turn = true;
			turn_count = 0;


			foreach (Control c in Controls)
				{
				try
					{
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
					}//end try

				catch { }

				}// end foreach

			}

		private void button_enter(object sender, EventArgs e)
			{
			Button b = (Button)sender;
			if (b.Enabled)
				{
				if (turn)
					b.Text = "X";
				else
					b.Text = "O";
				}
			}

		private void button_leave(object sender, EventArgs e)
			{
			Button b = (Button)sender;
			if (b.Enabled)
				b.Text = "";
			}

		private void resetResultToolStripMenuItem_Click(object sender, EventArgs e)
			{
			o_win_count.Text = "0";
			x_win_count.Text = "0";
			draw_count.Text = "0";
			}

		private void Form1_Load(object sender, EventArgs e)
			{
			setDefaultNamesPlayers();

			label1.Text = player1;
			label3.Text = player2;

			}
		}
	}



