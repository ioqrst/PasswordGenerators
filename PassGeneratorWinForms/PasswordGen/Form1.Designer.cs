namespace PasswordGen
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox3 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox4 = new MaterialSkin.Controls.MaterialCheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.AutoSize = true;
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(15, 447);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(55, 30);
			this.materialCheckBox1.TabIndex = 0;
			this.materialCheckBox1.Text = "A..Z";
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Location = new System.Drawing.Point(122, 405);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(80, 36);
			this.materialFlatButton1.TabIndex = 1;
			this.materialFlatButton1.Text = "GENERATE";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(325, 431);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(163, 19);
			this.materialLabel1.TabIndex = 2;
			this.materialLabel1.Text = "Enter Password Lenght";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.ForeColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(12, 79);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(476, 317);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(345, 453);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			// 
			// materialCheckBox2
			// 
			this.materialCheckBox2.AutoSize = true;
			this.materialCheckBox2.Depth = 0;
			this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox2.Location = new System.Drawing.Point(70, 447);
			this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox2.Name = "materialCheckBox2";
			this.materialCheckBox2.Ripple = true;
			this.materialCheckBox2.Size = new System.Drawing.Size(52, 30);
			this.materialCheckBox2.TabIndex = 5;
			this.materialCheckBox2.Text = "a..z ";
			this.materialCheckBox2.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox3
			// 
			this.materialCheckBox3.AutoSize = true;
			this.materialCheckBox3.Depth = 0;
			this.materialCheckBox3.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox3.Location = new System.Drawing.Point(122, 447);
			this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox3.Name = "materialCheckBox3";
			this.materialCheckBox3.Ripple = true;
			this.materialCheckBox3.Size = new System.Drawing.Size(53, 30);
			this.materialCheckBox3.TabIndex = 6;
			this.materialCheckBox3.Text = "0..9";
			this.materialCheckBox3.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox4
			// 
			this.materialCheckBox4.AutoSize = true;
			this.materialCheckBox4.Depth = 0;
			this.materialCheckBox4.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox4.Location = new System.Drawing.Point(175, 447);
			this.materialCheckBox4.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox4.Name = "materialCheckBox4";
			this.materialCheckBox4.Ripple = true;
			this.materialCheckBox4.Size = new System.Drawing.Size(131, 30);
			this.materialCheckBox4.TabIndex = 7;
			this.materialCheckBox4.Text = "Special Symbols";
			this.materialCheckBox4.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 500);
			this.Controls.Add(this.materialCheckBox4);
			this.Controls.Add(this.materialCheckBox3);
			this.Controls.Add(this.materialCheckBox2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.materialCheckBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "Form1";
			this.Text = "PasswordGenerator";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox3;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox4;
	}
}

