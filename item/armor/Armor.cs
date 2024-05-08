using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.item.armor
{
	public abstract class Armor : IItem
	{
		public string Name { get; set; }
		public double Weight { get; set; }
        public int Def { get; set; }
		public bool Stackable { get; set; } = false;

		public Armor()
		{
			Name = "Generic Armor";
			Weight = 0;
			Def = 0;
		}

		public Armor(string name, double weight, int def)
		{
			Name = name;
			Weight = weight;
			Def = def;
		}

		public override string ToString()
		{
			return string.Format("{0} | kg: {1} | {2}", Name, Weight, Def);
		}

		public abstract string Use(Entity target);
	}
}
