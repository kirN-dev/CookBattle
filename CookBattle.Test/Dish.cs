using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBattle.Test
{
	public class Dish
	{
		public Dish(string name, params Ingredient[] ingredients)
		{
			Ingredients = ingredients;
			Name = name;
		}
		public Ingredient[] Ingredients { get; }
		public string Name { get;}
		public override string ToString()
		{
			return Name;
		}
	}
}
