using RobotsTests.item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity
{
	public class Inventory
	{
		public List<IItem> Items { get; set; }

		public double MaxWeight { get; set; }
		public double Weight { get; set; }

		public Inventory()
		{
			Items = new List<IItem>();
		}

		public Inventory(double maxWeight)
		{
			Items = new List<IItem>();
			MaxWeight = maxWeight;
			Weight = 0;
		}

		public double GetWeight()
		{
			double weight = 0;

			foreach (var item in Items)
			{
				weight += item.Weight;
			}

			Weight = weight;

			return weight;
		}

		public string AddItem(IItem item)
		{
			if((Weight + item.Weight) <= MaxWeight)
			{
				Items.Add(item);
				Weight += item.Weight;
				return $"{item.Name} added";
			} else
			{
				return $"you are at max capacity&try dropping something";
			}
		}

		public string RemoveItem(IItem item)
		{
			Items.Remove(item);
			return $"{item.Name} removed";
		}

		public override string ToString()
		{
			string list = "";

			foreach (var item in Items)
			{
				list += item.ToString() + "&";
			}

			return list;
		}
	}
}
