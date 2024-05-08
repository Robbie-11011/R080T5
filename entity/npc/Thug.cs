using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity.npc
{
	public class Thug : Entity
	{
		public Thug() : base()
		{
			Name = "Generic Thug";

			stats = new Stats(100, 1, 1);
		}		
		
		public Thug(int hp, int atk, int def) : base()
		{
			Name = "Generic Thug";

			stats = new Stats(hp, atk, def);
		}

	}
}
