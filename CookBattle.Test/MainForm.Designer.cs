
namespace CookBattle.Test
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.EnemyScore = new System.Windows.Forms.Label();
			this.Time = new System.Windows.Forms.Label();
			this.Score = new System.Windows.Forms.Label();
			this.button11 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tOrder = new System.Windows.Forms.Timer(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.button12 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(9, 189);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Булочка";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(9, 229);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 32);
			this.button2.TabIndex = 1;
			this.button2.Text = "Котлета";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(113, 189);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 32);
			this.button3.TabIndex = 2;
			this.button3.Text = "Латук";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(113, 229);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 32);
			this.button4.TabIndex = 3;
			this.button4.Text = "Помидор";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 21;
			this.listBox1.Location = new System.Drawing.Point(4, 4);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(199, 130);
			this.listBox1.TabIndex = 4;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(211, 4);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(96, 32);
			this.button5.TabIndex = 5;
			this.button5.Text = "Сдать";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(211, 102);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(96, 32);
			this.button6.TabIndex = 6;
			this.button6.Text = "Очистить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 21;
			this.listBox2.Location = new System.Drawing.Point(8, 30);
			this.listBox2.Margin = new System.Windows.Forms.Padding(4);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(199, 130);
			this.listBox2.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.listBox2);
			this.groupBox1.Location = new System.Drawing.Point(556, 27);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(231, 168);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Заказы";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.EnemyScore);
			this.groupBox2.Controls.Add(this.Time);
			this.groupBox2.Controls.Add(this.Score);
			this.groupBox2.Controls.Add(this.button11);
			this.groupBox2.Controls.Add(this.button13);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.button10);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Location = new System.Drawing.Point(12, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(535, 283);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			// 
			// EnemyScore
			// 
			this.EnemyScore.AutoSize = true;
			this.EnemyScore.Location = new System.Drawing.Point(330, 130);
			this.EnemyScore.Name = "EnemyScore";
			this.EnemyScore.Size = new System.Drawing.Size(140, 21);
			this.EnemyScore.TabIndex = 17;
			this.EnemyScore.Text = "Счет соперника: 0";
			// 
			// Time
			// 
			this.Time.AutoSize = true;
			this.Time.Location = new System.Drawing.Point(330, 30);
			this.Time.Name = "Time";
			this.Time.Size = new System.Drawing.Size(101, 21);
			this.Time.TabIndex = 16;
			this.Time.Text = "Время: 01:00";
			// 
			// Score
			// 
			this.Score.AutoSize = true;
			this.Score.Location = new System.Drawing.Point(330, 92);
			this.Score.Name = "Score";
			this.Score.Size = new System.Drawing.Size(60, 21);
			this.Score.TabIndex = 15;
			this.Score.Text = "Счет: 0";
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button11.Location = new System.Drawing.Point(425, 189);
			this.button11.Margin = new System.Windows.Forms.Padding(4);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(96, 32);
			this.button11.TabIndex = 12;
			this.button11.Text = "Сосиска";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.button1_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(425, 229);
			this.button13.Margin = new System.Windows.Forms.Padding(4);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(96, 32);
			this.button13.TabIndex = 14;
			this.button13.Text = "Фарш";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button1_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button7.Location = new System.Drawing.Point(217, 189);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(96, 32);
			this.button7.TabIndex = 8;
			this.button7.Text = "Нори";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button1_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(217, 229);
			this.button8.Margin = new System.Windows.Forms.Padding(4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(96, 32);
			this.button8.TabIndex = 9;
			this.button8.Text = "Огурец";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button1_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(321, 189);
			this.button9.Margin = new System.Windows.Forms.Padding(4);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(96, 32);
			this.button9.TabIndex = 10;
			this.button9.Text = "Рис";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button1_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(321, 229);
			this.button10.Margin = new System.Windows.Forms.Padding(4);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(96, 32);
			this.button10.TabIndex = 11;
			this.button10.Text = "Макароны";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Location = new System.Drawing.Point(6, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 154);
			this.panel1.TabIndex = 7;
			// 
			// tOrder
			// 
			this.tOrder.Interval = 5000;
			this.tOrder.Tick += new System.EventHandler(this.tOrder_Tick);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(613, 238);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(103, 38);
			this.button12.TabIndex = 10;
			this.button12.Text = "Рецепты";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рецептыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 29);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// рецептыToolStripMenuItem
			// 
			this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
			this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
			this.рецептыToolStripMenuItem.Text = "Рецепты";
			this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.button12_Click);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 323);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Битва Кулинаров";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Timer tOrder;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem рецептыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Label Time;
		private System.Windows.Forms.Label Score;
		private System.Windows.Forms.Label EnemyScore;
	}
}

