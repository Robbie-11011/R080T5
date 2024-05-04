using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity.player
{
	public class Player : Entity
	{
		public Player() : base()
		{
			Name = "B0B";

			stats = new Stats(100, 1, 1);
		}
	}
}
