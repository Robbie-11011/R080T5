using RobotsLibrary;
using RobotsTests.entity.npc;
using RobotsTests.entity.player;

namespace RobotsTests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			Thug thug = new Thug();

			string[] lines = player.Attack(thug).Split("|");
			foreach (var line in lines)
			{
				Util.Println(line, ConsoleColor.Green);
			}



			bool end = false;

			while (!end)
			{
				Console.Write("cmd >> ");
				string input = "";
				input = Console.ReadLine();
				int mod = 0;
				bool pass = false;

				switch (input.ToLower())
				{
					case "exit":
						end = true;
						break;
					case "clear":
						Console.Clear();
						break;

					case "attack thug":
						player.Attack(thug);
						break;

					case "sudo attack player":
						thug.Attack(player);
						break;

					case "stats player":
						Util.Println(player.ToString());
						break;

					case "sudo stats thug":
						Util.Println(thug.ToString());
						break;

					case "sudo stats player hp":

						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						player.stats.Hp = mod;
						break;

					case "sudo stats player atk":
						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						player.stats.Atk = mod;
						break;

					case "sudo stats player def":
						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						player.stats.Def = mod;
						break;

					case "sudo stats thug hp":

						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						thug.stats.Hp = mod;
						break;

					case "sudo stats thug atk":
						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						thug.stats.Atk = mod;
						break;

					case "sudo stats thug def":
						while (!pass)
						{
							Console.Write("mod >> ");
							pass = int.TryParse(Console.ReadLine(), out mod);
						}
						thug.stats.Def = mod;
						break;

					default:
						Util.Println("Please try again", ConsoleColor.Red);
						break;

				}
			}
		}
	}
}
