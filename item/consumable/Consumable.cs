using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.item.consumable
{
	/// <summary>
	/// An abstract consumable item
	/// </summary>
	public abstract class Consumable : IItem, IStackable
	{
		public string Name { get; set; }
		public double Weight { get; set; }
		public bool Stackable { get; set; }
		public int StackLimit { get; set; }
        public int Qty { get; set; }

		/// <summary>
		/// Default Constructor
		/// </summary>
        public Consumable()
		{
			Name = "Generic Consumable";
			Weight = 0;
			Stackable = true;
			StackLimit = 0;
			Qty = 1;
		}

		/// <summary>
		/// Name | Weight (stackable = true | stackLimit = 8 | qty = 1)
		/// </summary>
		/// <param name="name"></param>
		/// <param name="weight"></param>
		public Consumable(string name, double weight)
		{
			Name = name;
			Weight = weight;
			Stackable = true;
			StackLimit = 8;
			Qty = 1;
		}			
		
		/// <summary> 
		/// Name | Weight | StackLimit (stackable = true | qty = 1)
		/// </summary>
		/// <param name="name"></param>
		/// <param name="weight"></param>
		/// <param name="stackLimit"></param>
		public Consumable(string name, double weight, int stackLimit)
		{
			Name = name;
			Weight = weight;
			Stackable = true;
			StackLimit = stackLimit;
			Qty = 1;
		}			
		
		/// <summary>
		/// Name | Weight | Stackable | StackLimit (stackLimit = 8 | qty = 1)
		/// </summary>
		/// <param name="name"></param>
		/// <param name="weight"></param>
		/// <param name="stackable"></param>
		/// <param name="stackLimit"></param>
		public Consumable(string name, double weight, bool stackable, int stackLimit)
		{
			Name = name;
			Weight = weight;
			Stackable = stackable;
			StackLimit = stackLimit;
			Qty = 1;
		}		

		/// <summary>
		/// Name | Weight | StackLimit | Qty (stackable = true)
		/// </summary>
		/// <param name="name"></param>
		/// <param name="weight"></param>
		/// <param name="stackLimit"></param>
		/// <param name="qty"></param>
		public Consumable(string name, double weight, int stackLimit, int qty)
		{
			Name = name;
			Weight = weight;
			Stackable = true;
			StackLimit = stackLimit;
			Qty = qty;
		}

		/// <summary>
		/// Use this item
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public abstract string Use(Entity target);

		/// <summary>
		/// A ToString method that displays the stats of the consumable
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0, -10} | kg: {1, -5} | qty: {2, -5}/{3, -5}", Name, Weight, Qty, StackLimit);
		}
	}
}
