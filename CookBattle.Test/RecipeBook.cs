using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBattle.Test
{
	class RecipeBook
	{
		private readonly Dictionary<string, Dish> _recipeBook = new Dictionary<string, Dish>();
		private readonly Random _random = new Random();

		public event Action ComplitedOrder;

		public RecipeBook()
		{
			_recipeBook.Add("Гамбургер",
				new Dish("Гамбургер",
				new Ingredient("Булочка"),
				new Ingredient("Котлета"),
				new Ingredient("Булочка")));

			_recipeBook.Add("Салат",
				new Dish("Салат",
				new Ingredient("Латук"),
				new Ingredient("Помидор")));

			_recipeBook.Add("Суши",
				new Dish("Суши",
				new Ingredient("Нори"),
				new Ingredient("Рис"),
				new Ingredient("Огурец")));
			
			_recipeBook.Add("Хот-дог",
				new Dish("Хот-дог",
				new Ingredient("Булочка"),
				new Ingredient("Сосиска"),
				new Ingredient("Булочка")));
			
			_recipeBook.Add("Паста",
				new Dish("Паста",
				new Ingredient("Макароны"),
				new Ingredient("Фарш"),
				new Ingredient("Помидор")));
		}

		public bool ChekedRecipe(List<Dish> orders, Dish checkedDish, out string nameDish)
		{
			foreach (var dish in orders)
			{
				if (dish.Ingredients.SequenceEqual(checkedDish.Ingredients))
				{
					nameDish = GetName(dish);
					orders.Remove(dish);
					ComplitedOrder?.Invoke();
					return true;
				}
			}

			nameDish = null;
			return false;
		}

		public bool Add(string name, Dish dish)
		{
			if (_recipeBook.ContainsKey(name))
			{
				return false;
			}

			_recipeBook.Add(name, dish);
			return true;
		}

		public bool Remove(string name)
		{
			if (!_recipeBook.ContainsKey(name))
			{
				return false;
			}

			_recipeBook.Remove(name);
			return true;
		}

		public KeyValuePair<string, Dish> GetRandomRecipe()
		{
			var name = _recipeBook.Keys.ElementAt(_random.Next(_recipeBook.Keys.Count));
			return _recipeBook.Where(r => r.Key == name).FirstOrDefault();
		}

		private string GetName(Dish dish)
		{
			return _recipeBook.Where(d => d.Value == dish).FirstOrDefault().Key;
		}
	}
}
