using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity.player
{
	public class Player : Entity
	{
        public int Trauma { get; set; }

        public Player() : base()
		{
			Name = "B0B";

			stats = new Stats(100, 1, 1);
			Trauma = 0;
		}

		public string AddTrauma(int mod, string type)
		{
			Trauma += mod;

			if(Trauma >= 100)
			{
				Dead = true;
				return $"trauma reached 100 & you are dead";
			} else if (Trauma >= 90)
			{
				if (type == "force")
				{
					stats.Def += 1;
				}
			}

			return $"Adding {mod} trauma";
		}


		/// <summary>
		/// Heals or damages the entity
		/// </summary>
		/// <param name="hp"></param>
		/// <returns></returns>
		public override string Heal(int hp, string type)
		{
			int oldHp = stats.Hp;
			stats.Hp += hp;

			if (hp < 0)
			{
				AddTrauma(-hp, type);

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
			return $"{Name,-16} | HP: {stats.Hp,-8} | ATK: {stats.Atk,-8} | DEF: {stats.Def,-8} | TRAUMA: {Trauma}";
		}
	}
}
