using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBattle.Test
{
	public partial class MainForm : Form
	{
		private List<Ingredient> _ingredients = new List<Ingredient>();
		private RecipeBook _recipeBook = new RecipeBook();
		private List<Dish> _orders = new List<Dish>();

		public MainForm()
		{
			InitializeComponent();

			for (int i = 0; i < 5; i++)
			{
				var order = _recipeBook.GetRandomRecipe();
				_orders.Add(order.Value);
			}

			listBox2.DataSource = _orders;
			_recipeBook.ComplitedOrder += _recipeBook_ComplitedOrder;
		}

		private void _recipeBook_ComplitedOrder()
		{
			listBox2.DataSource = _orders.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var ingredient = new Ingredient("Breed", Color.SandyBrown);
			_ingredients.Add(ingredient);
			listBox1.Items.Add(ingredient);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var ingredient = new Ingredient("Cutlet", Color.Brown);
			_ingredients.Add(ingredient);
			listBox1.Items.Add(ingredient);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var ingredient = new Ingredient("Lettuce", Color.LightSlateGray);
			_ingredients.Add(ingredient);
			listBox1.Items.Add(ingredient);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var ingredient = new Ingredient("Tomato", Color.OrangeRed);
			_ingredients.Add(ingredient);
			listBox1.Items.Add(ingredient);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			_ingredients.Clear();
			listBox1.Items.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var dish = new Dish(string.Empty, _ingredients.ToArray());

			button6.PerformClick();

			if (!_recipeBook.ChekedRecipe(_orders, dish, out string name))
			{
				MessageBox.Show("Нет такого");
				return;
			}

			MessageBox.Show(name);
		}
	}
}
