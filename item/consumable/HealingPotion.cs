using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.item.consumable
{
	/// <summary>
	/// A healing potion
	/// </summary>
	public class HealingPotion : Consumable
	{
        public int Mod { get; set; } /// Healing modifier

		public HealingPotion(int mod) : base()
		{
			Mod = mod;
		}

		/// <summary>
		/// Heal the target
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
        public override string Use(Entity target)
		{
			target.Heal(Mod, "heal");

			return $"Restored {Mod} HP|1 {this.Name} consumed";
		}

		/// <summary>
		/// A ToString method that displays the stats of the healing potion
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0, -10} | kg: {1, -5} | qty: {2, -5}/{3, -5} | {4, -5}", Name, Weight, Qty, StackLimit, Mod);
		}
	}
}
