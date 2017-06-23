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
		static public bool registration = false;
		static public bool logInLogin = false;
		static public bool LogInPas = false;
		static public bool check_rule = false;
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

		static public void SearchPlayer()
			{
			StreamReader profile = new StreamReader(@"C:\TicTacToe Game\Profile\Profile.txt", Encoding.Default);
			while (!profile.EndOfStream)
				{
				string st = profile.ReadLine();
				if (st.StartsWith(login))
					{
					Console.WriteLine("Registed!");
					registration = false;
					logInLogin = true;
					break;
					}
				else
					{
					registration = true;
					logInLogin = false;
					}
				}
			profile.Close();
			}

		static public void CheckPasswordPlayer()
			{
			if(logInLogin)
				{
					StreamReader CheckPassword = new StreamReader(@"C:\TicTacToe Game\Profile\Profile.txt", Encoding.Default);
					while (!CheckPassword.EndOfStream)
						{
						string st = CheckPassword.ReadLine();
						if (st.StartsWith(password))
							{
							Console.WriteLine("Done!");
							LogInPas = true;
							break;
							}
						else
							{
							registration = true;
							LogInPas = false;
							}
						}
					CheckPassword.Close();
				}
			}

		static private void CreateNewPlayer()
			{
			SearchPlayer();
			try
				{
				if (registration)
					{
					StreamWriter profile = new StreamWriter(@"C:\TicTacToe Game\Profile\Profile.txt", true);
					profile.WriteLine(login + " " + password + "\n");
					profile.Close();
					Console.WriteLine("Register is Done!");
					}
				}
			catch {}
			}

		static private void CheckTextLoginAndPassword(String n1, String n2)
			{
			if ((n1 == "") || (n2 == ""))
				{
				Console.WriteLine("Enter your Login or Password!");
				registration = false;
				check_rule = false;
				}
			}

		static private void CheckRule()
			{
			if((logInLogin==true) && (LogInPas==true))
				{
				check_rule = true;
				}
			}
		static public void Registration(String n1, String n2)
			{
			setLoginPlayer(n1);
			setPasswordPlayer(n2);
			CreateDirectory();
			CreateProfileFIle();
			CheckTextLoginAndPassword(n1,n2);
			CreateNewPlayer();
			}

		static public void LogInPlayer(String n1, String n2)
			{
			setLoginPlayer(n1);
			setPasswordPlayer(n2);
			CreateProfileFIle();
			SearchPlayer();
			CheckPasswordPlayer();
			CheckTextLoginAndPassword(n1,n2);
			CheckRule();
			}
		}
	} 




