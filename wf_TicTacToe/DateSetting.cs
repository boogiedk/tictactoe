using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wf_TicTacToe
	{
	static class DateSetting
		{
		static String login;
		static String password;
		static string[] bar_menu = { "login", " ", "password" };
		static public bool registration = false;

		static public void setLoginPlayer(String n1)
			{
			login = n1;
			}

		static public void setPasswordPlayer(String n1)
			{
			password = n1;
			}
		static private void CreateDirectory()
			{
			DirectoryInfo TicTacToe = new DirectoryInfo(@"C:\");
			try
				{
				TicTacToe.CreateSubdirectory("TicTacToe Game");
				TicTacToe.CreateSubdirectory(@"TicTacToe Game\Profile");
				}
			catch (IOException e)
				{
				Console.WriteLine(e.Message);
				}
			}

		static private void CreateProfileFIle()
			{
			FileInfo profile = new FileInfo(@"C:\TicTacToe Game\Profile\Profile.txt");
			FileStream s = profile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
			s.Close();
			}

		static private void SearchPlayer()
			{
			StreamReader profile = new StreamReader(@"C:\TicTacToe Game\Profile\Profile.txt", Encoding.Default);
			while (!profile.EndOfStream)
				{
				string st = profile.ReadLine();
				if (st.StartsWith(login))
					{
					Console.WriteLine("Registed!");
					registration = false;
					break;
					}
				else
					{
					registration = true;
					}
				}
			profile.Close();
			}

		static private void CreateNewPlayer()
			{
			SearchPlayer();
			if (registration)
				{
				StreamWriter profile = new StreamWriter(@"C:\TicTacToe Game\Profile\Profile.txt", true);
				profile.WriteLine(login + " " + password + "\n");
				profile.Close();
				Console.WriteLine("Register is Done!");
				}
			}

		static public void Regisrtation(String n1, String n2)
			{
			setLoginPlayer(n1);
			setPasswordPlayer(n2);
			CreateDirectory();
			CreateProfileFIle();
			CreateNewPlayer();
			}
	
		}
	}




