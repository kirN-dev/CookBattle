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
		private readonly Random _random = new Random();

		private int _time;
		private int _score = 0;
		private int _enemyScore = 0;

		public MainForm()
		{
			InitializeComponent();

			_recipeBook.ComplitedOrder += _recipeBook_ComplitedOrder;

		}

		private void NewOrder()
		{
			for (int i = 0; i < 3; i++)
			{
				var order = _recipeBook.GetRandomRecipe();
				_orders.Add(order.Value);
			}

			listBox2.DataSource = _orders.ToList();
		}

		private void _recipeBook_ComplitedOrder()
		{
			listBox2.DataSource = _orders.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var ingredient = new Ingredient((sender as Button).Text);
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

			Score.Text = string.Format("Счет: {0}", ++_score);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			RecipeForm recipeForm = new RecipeForm();
			recipeForm.ShowDialog();
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Разработчик: Павел Ракин ИСП-41");
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void tOrder_Tick(object sender, EventArgs e)
		{
			var order = _recipeBook.GetRandomRecipe();
			_orders.Add(order.Value);
			listBox2.DataSource = _orders.ToList();
			_enemyScore += _random.Next(4);
			EnemyScore.Text = string.Format("Счет соперника: {0}", _enemyScore);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			Time.Text = string.Format("Время: 00:{0}", (--_time).ToString("00"));

			if (_time <= 0)
			{
				timer.Stop();
				tOrder.Stop();
				string messege = _score > _enemyScore ? "Победа" : "Поражение ";

				StartForm startForm = new StartForm(messege, true);
				startForm.ShowDialog();

				NewGame(startForm);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var messege = "Добро пожаловать на Битву Кулинаров.\n\n Вам предстоит побороться\n в состязании с другими претендентами\n и стать лучшим из лучших";

			StartForm startForm = new StartForm(messege);
			startForm.ShowDialog();

			NewGame(startForm);
		}

		private void NewGame(StartForm startForm)
		{
			if (!startForm.Start)
			{
				return;
			}

			button6.PerformClick();
			_orders.Clear();
			NewOrder();

			tOrder.Start();
			timer.Start();

			_score = _enemyScore = 0;
			EnemyScore.Text = string.Format("Счет соперника: {0}", _enemyScore);
			Score.Text = string.Format("Счет: {0}", _score);
			_time = 60;
			Time.Text = string.Format("Время: 01:00");
		}
	}
}
