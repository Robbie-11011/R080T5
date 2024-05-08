using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.item
{
	public interface IItem
	{
        public string Name { get; set; }
        public double Weight { get; set; }
        public bool Stackable { get; set; }

        public string ToString();
        public string Use(Entity target);
    }
}
