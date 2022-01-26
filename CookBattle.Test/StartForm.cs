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
	public partial class StartForm : Form
	{
		public StartForm(string messege, bool isRestart = false)
		{
			InitializeComponent();

			label1.Text = messege;

			button1.Text = isRestart? "Ещё раз?" : "Начать";
		}

		public bool Start { get; set; } = false;

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Start = true;
			Close();
		}

		private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Start)
			{
				Application.Exit();
			}
		}
	}
}
