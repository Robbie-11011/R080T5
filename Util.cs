using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsLibrary
{
	public static class Util
	{
		public static void Print(string txt)
		{
			Console.Write("[ {0} ]", txt.ToUpper());
		}

		public static void Print(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write("[ {0} ]", txt.ToUpper());
			Console.ResetColor();
		}		
		
		public static void Println(string txt)
		{
			Console.WriteLine("[ {0} ]", txt.ToUpper());
		}		
		
		public static void Println(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine("[ {0} ]", txt.ToUpper());
			Console.ResetColor();
		}
	}
}
