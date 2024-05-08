using RobotsLibrary;
using RobotsTests.entity;
using RobotsTests.entity.npc;
using RobotsTests.entity.player;
using RobotsTests.item.consumable;

namespace RobotsTests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			List<Entity> targets = new List<Entity>();

			

			for (int i = 0; i < 10; i++) {
				targets.Add(new Thug(Util.Rand(10, 100), Util.Rand(1, 10), Util.Rand(10)));
			}

			bool end = false;

			while (!end)
			{
				Console.Write("cmd >> ");
				string input = Console.ReadLine();

				Command(player, targets, input, ref end);
			}
		}

		public static void Command(Entity player, List<Entity> targets, string input, ref bool end)
		{
			Consumable minorHealingPotion = new HealingPotion(Util.Rand(1, 10));

			int i, mod;

			switch (input.ToLower())
			{
				case "exit":
					end = true;
					break;

				case "clear":
					Console.Clear();
					break;

				case "attack target":
					i = Util.GetUserIndex(targets);
					Util.SplitPrint(player.Attack(targets[i], "force"));
					break;

				case "sudo target attack player":
					i = Util.GetUserIndex(targets);
					Util.SplitPrint(targets[i].Attack(player, "force"));
					break;

				case "get player.stats":
					Util.Println(player.ToString());
					break;

				case "get targets":
					Util.PrintList(targets);
					break;

				case "sudo get target.stats":
					i = Util.GetUserIndex(targets);
					Util.Println(targets[i].ToString());
					break;

				case "sudo get targets.stats -a":
					Util.PrintListStats(targets);
					break;

				case "sudo set player.hp":
					mod = Util.GetUserMod();
					player.stats.Hp = mod;
					break;

				case "sudo set player.atk":
					mod = Util.GetUserMod();
					player.stats.Atk = mod;
					break;

				case "sudo set player.def":
					mod = Util.GetUserMod();
					player.stats.Def = mod;
					break;

				case "sudo set target.hp":
					i = Util.GetUserIndex(targets);
					mod = Util.GetUserMod();
					targets[i].stats.Hp = mod;
					break;

				case "sudo set target.atk":
					i = Util.GetUserIndex(targets);
					mod = Util.GetUserMod();
					targets[i].stats.Atk = mod;
					break;

				case "sudo set target.def":
					i = Util.GetUserIndex(targets);
					mod = Util.GetUserMod();
					targets[i].stats.Def = mod;
					break;

				case "use item":
					// Change to selecting from a list of items later
					// It works
					Util.SplitPrint(minorHealingPotion.Use(player));
					break;

				case "get item":
					Util.Println(minorHealingPotion.ToString());
					break;

				default:
					Util.Println("Please try again", ConsoleColor.Red);
					break;
			}
		}
	}
}
