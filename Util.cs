using RobotsTests.entity;
using RobotsTests.entity.npc;
using RobotsTests.entity.player;
using RobotsTests.item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

		public static void SplitPrint(string str)
		{
			string del = "&";

			string[] lines = str.Split(del);

			foreach (var line in lines)
			{
				Util.Println(line, ConsoleColor.Green);
			}
		}



		public static int Rand(int max)
		{
			return new Random().Next(max + 1);
		}

		public static int Rand(int min, int max)
		{
			return new Random().Next(min, max + 1);
		}

		public static void PrintList(List<Entity> entities)
		{
			for (int i = 0; i < entities.Count; i++)
			{
				Println($"{i + 1,-5} {entities[i].Name}");
			}
		}

		public static void PrintList(List<IItem> items)
		{
			for (int i = 0; i < items.Count; i++)
			{
				Println($"{i + 1,-5} {items[i].ToString()}");
			}
		}

		public static void PrintListStats(List<Entity> entities)
		{
			for (int i = 0; i < entities.Count; i++)
			{
				Println($"{i + 1,-5} {entities[i]}");
			}
		}

		public static int GetUserIndex(List<Entity> targets)
		{
			bool pass = false;
			int mod = 0;

			PrintList(targets);

			while (!pass)
			{
				Console.Write("target index >> ");
				pass = int.TryParse(Console.ReadLine(), out mod);

				if (mod >= targets.Count + 1 || mod < 0)
				{
					pass = false;
					Util.SplitPrint("Out of range&Please try again");
				}
			}

			return (mod - 1);
		}

		public static int GetUserIndex(List<IItem> items)
		{
			bool pass = false;
			int mod = 0;


			PrintList(items);


			while (!pass)
			{
				Console.Write("target index >> ");
				string str = Console.ReadLine();

				if (str.ToLower().Equals("exit"))
				{
					return -1;
				}

				pass = int.TryParse(str, out mod);

				if (mod >= items.Count + 1 || mod < 0)
				{
					pass = false;
					Util.SplitPrint("Out of range&Please try again");
				}
			}

			return (mod - 1);
		}

		public static int GetUserMod()
		{
			bool pass = false;
			int mod = 0;

			while (!pass)
			{
				Console.Write("mod >> ");
				pass = int.TryParse(Console.ReadLine(), out mod);
			}

			return mod;
		}
	}
}