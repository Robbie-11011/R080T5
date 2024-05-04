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

		/// <summary>
		/// Heal the target
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
        public override string Use(Entity target)
		{
			target.Heal(Mod);

			return $"Restored {Mod} HP|1 {this.Name} consumed";
		}
	}
}
