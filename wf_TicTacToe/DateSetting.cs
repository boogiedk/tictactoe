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
				TicTacToe.CreateSubdirectory(@"TicTacToe Game\Players");
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

		static private void CheckPasswordPlayer()
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
			if ((n1 == "") || (n1==" "))
				{
				check_rule = false;
				}
			else if ((n2 == "") || (n2==" "))
				{
				check_rule = false;
				}
			else
				{
				check_rule = true;
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
			CreateNewPlayer();
			CreatePersonalProfile();
			SetDateAboutPlayer();
			CheckTextLoginAndPassword(n1, n2);
			}

		static public void LogInPlayer(String n1, String n2)
			{
			setLoginPlayer(n1);
			setPasswordPlayer(n2);
			CreateProfileFIle();
			CreatePersonalProfile();
			LogInPersonalProfile();
			SetDateAboutPlayer();
			CheckPasswordPlayer();
			CheckTextLoginAndPassword(n1,n2);
			CheckRule();
			}

		//             //               //              //            //            //            //            //          //        //

		static private void CreatePersonalProfile()
			{
			FileInfo PersonalProfile = new FileInfo(@"C:\TicTacToe Game\Players\" + login + ".txt");
			FileStream s = PersonalProfile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
			s.Close();
			}
		static private void SetDateAboutPlayer()
			{
				StreamWriter PersonalProfile = new StreamWriter(@"C:\TicTacToe Game\Players\" + login + ".txt", true);
				PersonalProfile.WriteLine(login + " " + password + "\n");
				PersonalProfile.Close();
			}
		static private void LogInPersonalProfile()
			{
			StreamReader profile = new StreamReader(@"C:\TicTacToe Game\Players\"+ login + ".txt", Encoding.Default);
			while (!profile.EndOfStream)
				{
				string st = profile.ReadLine();
				if (st.StartsWith((login)) & (st.StartsWith((password)))) 
					{
					Console.WriteLine("Registed!");
					logInLogin = true;
					LogInPas=true;
					break;
					}
				else
					{
					logInLogin = false;
					LogInPas=false;
					}
				}
			profile.Close();
			}
		}
		
	} 




