using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf_TicTacToe
	{
	public partial class Form2 : Form
		{
		bool result_check = false;
		public Form2()
			{
			InitializeComponent();
			}

		private void button1_Click(object sender, EventArgs e)
			{
			Form1.setPlayersNames(p1.Text, p2.Text);
			Form1.get_against_computer(botOrPlayer.Checked);
			this.Hide();
			Form1 f1 = new Form1();
			f1.Show();
			}
		
		private void p2_KeyPress(object sender, KeyPressEventArgs e)
			{
			if (e.KeyChar.ToString() == "\r")
				button1.PerformClick();
			}

			private void CheckTextLoginAndPassword()
			{
			if(textBoxLogin.Text == "")
				{
				MessageBox.Show("Enter your Login!");
				result_check = false;
				}
			else if(textBoxPassword.Text=="")
				{
				MessageBox.Show("Enter your Password!");
				result_check = false;
				}
			else
				{
				result_check = true;
				}
			}
		private void button2_Click(object sender, EventArgs e)
			{

			CheckTextLoginAndPassword();

			if (result_check)
				{
				DateSetting.Registration(textBoxLogin.Text, textBoxPassword.Text);
				if (DateSetting.registration)
					{
					MessageBox.Show(textBoxLogin.Text + " is registered!");
					Form1.setPlayersNames(textBoxLogin.Text, "");
					this.Hide();
					Form1 f1 = new Form1();
					f1.Show();
					}
				else
					{
					MessageBox.Show(textBoxLogin.Text + " registered already! Try again!");
					}
				}
			}

		private void button3_Click(object sender, EventArgs e)
			{
			DateSetting.LogInPlayer(textBox1.Text, textBox2.Text);
			if (DateSetting.logInLogin)
				{
				if (DateSetting.LogInPas)
					{
					Form1.setPlayersNames(textBox1.Text, "");
					this.Hide();
					Form1 f1 = new Form1();
					f1.Show();
					}
				else
					MessageBox.Show("invalid password!");
				}
			else
				MessageBox.Show("invalid login!");
			}
		}
	}
