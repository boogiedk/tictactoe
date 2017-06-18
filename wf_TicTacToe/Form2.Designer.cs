namespace wf_TicTacToe
	{
	partial class Form2
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.p1 = new System.Windows.Forms.TextBox();
			this.p2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.botOrPlayer = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Blade Runner Movie Font", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Fuchsia;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player One Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Blade Runner Movie Font", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Fuchsia;
			this.label2.Location = new System.Drawing.Point(13, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Player Two Name:";
			// 
			// p1
			// 
			this.p1.BackColor = System.Drawing.Color.Fuchsia;
			this.p1.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p1.Location = new System.Drawing.Point(218, 12);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(106, 21);
			this.p1.TabIndex = 2;
			// 
			// p2
			// 
			this.p2.BackColor = System.Drawing.Color.Fuchsia;
			this.p2.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p2.Location = new System.Drawing.Point(218, 46);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(106, 21);
			this.p2.TabIndex = 3;
			this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_KeyPress);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(249, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// botOrPlayer
			// 
			this.botOrPlayer.AutoSize = true;
			this.botOrPlayer.BackColor = System.Drawing.Color.Transparent;
			this.botOrPlayer.Font = new System.Drawing.Font("Blade Runner Movie Font", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botOrPlayer.ForeColor = System.Drawing.Color.Fuchsia;
			this.botOrPlayer.Location = new System.Drawing.Point(165, 73);
			this.botOrPlayer.Name = "botOrPlayer";
			this.botOrPlayer.Size = new System.Drawing.Size(161, 18);
			this.botOrPlayer.TabIndex = 5;
			this.botOrPlayer.Text = "Play with COMPUTER";
			this.botOrPlayer.UseVisualStyleBackColor = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(338, 144);
			this.Controls.Add(this.botOrPlayer);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.p2);
			this.Controls.Add(this.p1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TicTacToe";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox p1;
		private System.Windows.Forms.TextBox p2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox botOrPlayer;
		}
	}