namespace wf_TicTacToe
	{
	partial class Form1
		{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gameplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.x_win_count = new System.Windows.Forms.Label();
			this.draw_count = new System.Windows.Forms.Label();
			this.o_win_count = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(348, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetResultToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Blade Runner Movie Font", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// resetResultToolStripMenuItem
			// 
			this.resetResultToolStripMenuItem.Name = "resetResultToolStripMenuItem";
			this.resetResultToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.resetResultToolStripMenuItem.Text = "Reset result ";
			this.resetResultToolStripMenuItem.Click += new System.EventHandler(this.resetResultToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameplayToolStripMenuItem});
			this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Blade Runner Movie Font", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// gameplayToolStripMenuItem
			// 
			this.gameplayToolStripMenuItem.Name = "gameplayToolStripMenuItem";
			this.gameplayToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.gameplayToolStripMenuItem.Text = "Gameplay";
			this.gameplayToolStripMenuItem.Click += new System.EventHandler(this.gameplayToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.donateToolStripMenuItem});
			this.helpToolStripMenuItem.Font = new System.Drawing.Font("Blade Runner Movie Font", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// donateToolStripMenuItem
			// 
			this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
			this.donateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.donateToolStripMenuItem.Text = "Donate";
			// 
			// A1
			// 
			this.A1.BackColor = System.Drawing.Color.Black;
			this.A1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A1.BackgroundImage")));
			this.A1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A1.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.Image = ((System.Drawing.Image)(resources.GetObject("A1.Image")));
			this.A1.Location = new System.Drawing.Point(16, 31);
			this.A1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(100, 81);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = false;
			this.A1.Click += new System.EventHandler(this.button_click);
			this.A1.MouseEnter += new System.EventHandler(this.button_enter);
			this.A1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A2
			// 
			this.A2.BackColor = System.Drawing.Color.Black;
			this.A2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A2.BackgroundImage")));
			this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A2.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
			this.A2.Location = new System.Drawing.Point(124, 31);
			this.A2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.A2.Name = "A2";
			this.A2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.A2.Size = new System.Drawing.Size(100, 81);
			this.A2.TabIndex = 2;
			this.A2.UseVisualStyleBackColor = false;
			this.A2.Click += new System.EventHandler(this.button_click);
			this.A2.MouseEnter += new System.EventHandler(this.button_enter);
			this.A2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A3
			// 
			this.A3.BackColor = System.Drawing.Color.Black;
			this.A3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A3.BackgroundImage")));
			this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A3.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
			this.A3.Location = new System.Drawing.Point(232, 31);
			this.A3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(100, 81);
			this.A3.TabIndex = 3;
			this.A3.UseVisualStyleBackColor = false;
			this.A3.Click += new System.EventHandler(this.button_click);
			this.A3.MouseEnter += new System.EventHandler(this.button_enter);
			this.A3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B1
			// 
			this.B1.BackColor = System.Drawing.Color.Black;
			this.B1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B1.BackgroundImage")));
			this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B1.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Image = ((System.Drawing.Image)(resources.GetObject("B1.Image")));
			this.B1.Location = new System.Drawing.Point(16, 118);
			this.B1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(100, 81);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = false;
			this.B1.Click += new System.EventHandler(this.button_click);
			this.B1.MouseEnter += new System.EventHandler(this.button_enter);
			this.B1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B2
			// 
			this.B2.BackColor = System.Drawing.Color.Black;
			this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
			this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B2.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Image = ((System.Drawing.Image)(resources.GetObject("B2.Image")));
			this.B2.Location = new System.Drawing.Point(124, 118);
			this.B2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(100, 81);
			this.B2.TabIndex = 5;
			this.B2.UseVisualStyleBackColor = false;
			this.B2.Click += new System.EventHandler(this.button_click);
			this.B2.MouseEnter += new System.EventHandler(this.button_enter);
			this.B2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B3
			// 
			this.B3.BackColor = System.Drawing.Color.Black;
			this.B3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B3.BackgroundImage")));
			this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B3.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Image = ((System.Drawing.Image)(resources.GetObject("B3.Image")));
			this.B3.Location = new System.Drawing.Point(232, 118);
			this.B3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(100, 81);
			this.B3.TabIndex = 6;
			this.B3.UseVisualStyleBackColor = false;
			this.B3.Click += new System.EventHandler(this.button_click);
			this.B3.MouseEnter += new System.EventHandler(this.button_enter);
			this.B3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C1
			// 
			this.C1.BackColor = System.Drawing.Color.Black;
			this.C1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C1.BackgroundImage")));
			this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C1.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.Image = ((System.Drawing.Image)(resources.GetObject("C1.Image")));
			this.C1.Location = new System.Drawing.Point(16, 206);
			this.C1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(100, 81);
			this.C1.TabIndex = 7;
			this.C1.UseVisualStyleBackColor = false;
			this.C1.Click += new System.EventHandler(this.button_click);
			this.C1.MouseEnter += new System.EventHandler(this.button_enter);
			this.C1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C2
			// 
			this.C2.BackColor = System.Drawing.Color.Black;
			this.C2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C2.BackgroundImage")));
			this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C2.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.Image = ((System.Drawing.Image)(resources.GetObject("C2.Image")));
			this.C2.Location = new System.Drawing.Point(124, 206);
			this.C2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(100, 81);
			this.C2.TabIndex = 8;
			this.C2.UseVisualStyleBackColor = false;
			this.C2.Click += new System.EventHandler(this.button_click);
			this.C2.MouseEnter += new System.EventHandler(this.button_enter);
			this.C2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C3
			// 
			this.C3.BackColor = System.Drawing.Color.Black;
			this.C3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C3.BackgroundImage")));
			this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C3.Font = new System.Drawing.Font("Blade Runner Movie Font", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.Image = ((System.Drawing.Image)(resources.GetObject("C3.Image")));
			this.C3.Location = new System.Drawing.Point(232, 206);
			this.C3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(100, 81);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = false;
			this.C3.Click += new System.EventHandler(this.button_click);
			this.C3.MouseEnter += new System.EventHandler(this.button_enter);
			this.C3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Fuchsia;
			this.label1.Location = new System.Drawing.Point(16, 298);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.MaximumSize = new System.Drawing.Size(105, 14);
			this.label1.MinimumSize = new System.Drawing.Size(105, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 14);
			this.label1.TabIndex = 10;
			this.label1.Text = "X Win ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Fuchsia;
			this.label2.Location = new System.Drawing.Point(125, 298);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.MaximumSize = new System.Drawing.Size(105, 14);
			this.label2.MinimumSize = new System.Drawing.Size(105, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 14);
			this.label2.TabIndex = 11;
			this.label2.Text = "Draw ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Fuchsia;
			this.label3.Location = new System.Drawing.Point(228, 298);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.MaximumSize = new System.Drawing.Size(105, 14);
			this.label3.MinimumSize = new System.Drawing.Size(105, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 14);
			this.label3.TabIndex = 12;
			this.label3.Text = "O Win ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// x_win_count
			// 
			this.x_win_count.AutoSize = true;
			this.x_win_count.BackColor = System.Drawing.Color.Black;
			this.x_win_count.ForeColor = System.Drawing.Color.Fuchsia;
			this.x_win_count.Location = new System.Drawing.Point(53, 317);
			this.x_win_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.x_win_count.Name = "x_win_count";
			this.x_win_count.Size = new System.Drawing.Size(14, 14);
			this.x_win_count.TabIndex = 13;
			this.x_win_count.Text = "0";
			// 
			// draw_count
			// 
			this.draw_count.AutoSize = true;
			this.draw_count.BackColor = System.Drawing.Color.Black;
			this.draw_count.ForeColor = System.Drawing.Color.Fuchsia;
			this.draw_count.Location = new System.Drawing.Point(164, 317);
			this.draw_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.draw_count.Name = "draw_count";
			this.draw_count.Size = new System.Drawing.Size(14, 14);
			this.draw_count.TabIndex = 14;
			this.draw_count.Text = "0";
			// 
			// o_win_count
			// 
			this.o_win_count.AutoSize = true;
			this.o_win_count.BackColor = System.Drawing.Color.Black;
			this.o_win_count.ForeColor = System.Drawing.Color.Fuchsia;
			this.o_win_count.Location = new System.Drawing.Point(275, 317);
			this.o_win_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.o_win_count.Name = "o_win_count";
			this.o_win_count.Size = new System.Drawing.Size(14, 14);
			this.o_win_count.TabIndex = 15;
			this.o_win_count.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(348, 341);
			this.Controls.Add(this.o_win_count);
			this.Controls.Add(this.draw_count);
			this.Controls.Add(this.x_win_count);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label x_win_count;
		private System.Windows.Forms.Label draw_count;
		private System.Windows.Forms.Label o_win_count;
		private System.Windows.Forms.ToolStripMenuItem resetResultToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gameplayToolStripMenuItem;

		}
	}

