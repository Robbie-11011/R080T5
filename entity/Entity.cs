using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity
{
	public abstract class Entity
	{
		public string Name { get; set; }

		public Stats stats { get; set; }
		public Inventory inventory { get; set; }
		public Equipment equipment { get; set; }
		public bool Dead { get; set; }

		public Entity()
		{
			Name = "B0B";

			stats = new Stats();
			inventory = new Inventory();
			equipment = new Equipment();
		}

		public string Attack(Entity target, string type)
		{
			string str = "";

			if (target.stats.Def < stats.Atk)
			{
				str += "&" + target.Heal(-stats.Atk, type);

			} else
			{
				str += "&No effect";
			}

			return $"{Name} attacks {target.Name}{str}";
		}

		/// <summary>
		/// Heals or damages the entity
		/// </summary>
		/// <param name="hp"></param>
		/// <returns></returns>
		public virtual string Heal(int hp, string type)
		{
			int oldHp = stats.Hp;
			stats.Hp += hp;

			if (hp < 0)
			{
				if (stats.Hp > 0)
				{
					return $"{Name} has taken {-hp} dmg";
				}
				else
				{
					stats.Hp = 0;
					return $"{Name} is dead";
				}

			}
			else if (hp == 0)
			{
				return $"No effect";
			}
			else
			{
				if (stats.Hp > 100)
				{
					stats.Hp = 100;
				}

				return $"{Name} restores {stats.Hp - oldHp} hp";
			}
		}

		public override string ToString()
		{
			return $"{Name,-16} | HP: {stats.Hp,-8} | ATK: {stats.Atk,-8} | DEF: {stats.Def,-8}";
		}
	}
}
