using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.item.weapon
{
	public abstract class Weapon : IItem, IEquippable
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public bool Stackable { get; set; } = false;

		public bool Equipped { get; set; }

		public Weapon()
		{
			Name = "Generic Weapon";
			Weight = 0;
			Equipped = false;
		}

		public Weapon(string name, double weight, bool equipped)
		{
			Name = name;
			Weight = weight;
			Equipped = equipped;
		}

		public override string ToString()
		{
			return string.Format("{0} | kg: {1} | {2}", Name, Weight, (Equipped) ? "Equipped" : "Unequipped");
		}

		public abstract string Use(Entity target);
	}
}
