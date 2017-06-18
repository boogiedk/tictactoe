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
		static int age;


		static public void setLoginPlayer(String n1)
			{
			login = n1;
			}
	static	public void setAgePlayer(int n1)
			{
			age = n1;
			}

	static	private void CreateDateFile()
			{
			StreamWriter write_text;  //Класс для записи в файл
			FileInfo file = new FileInfo("C://config.txt");
			write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
			write_text.WriteLine(login, " ", age); //Записываем в файл текст из текстового поля
			write_text.Close(); // Закрываем файл
			}
		}
	}
