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
		public Form2()
			{
			InitializeComponent();
			}
		private void button1_Click(object sender, EventArgs e)
			{
			Form1.setPlayersNames(p1.Text, p2.Text);
	
			Form1.get_against_computer(botOrPlayer.Checked);

			this.Close();


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
				}
			else if(textBoxPassword.Text=="")
				{
				MessageBox.Show("Enter your Password!");
				}
			}
		private void button2_Click(object sender, EventArgs e)
			{
			CheckTextLoginAndPassword();
			DateSetting.Regisrtation(textBoxLogin.Text, textBoxPassword.Text);
			if (DateSetting.registration)
				{
				MessageBox.Show(textBoxLogin.Text + " is registered!");
				Form1.setPlayersNames(textBoxLogin.Text);
				}
			else
				{
				MessageBox.Show(textBoxLogin.Text + " registered already! Try again!");
				}
			}
		}
	}
