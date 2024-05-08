using RobotsTests.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.location
{
	public class Location
	{
        public string Name { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public List<Entity> Entities { get; set; } = new List<Entity>();

		public Location()
        {
            Name = "";
            Width = 0;
            Length = 0;
        }

        public Location(string name, int width, int length)
        {
            Name = name;
            Width = width;
            Length = length;
        }
    }
}
