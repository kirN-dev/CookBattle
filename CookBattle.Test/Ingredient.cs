using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBattle.Test
{
	public struct Ingredient : IComparable
	{
		public Ingredient(string name)
		{
			Name = name;
		}
		public string Name { get; }

		public int CompareTo(object obj)
		{
			var ingredient = (Ingredient)obj;
			return Name.CompareTo(ingredient.Name);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
