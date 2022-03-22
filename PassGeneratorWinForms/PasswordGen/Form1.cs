using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PasswordGen
{
	public partial class Form1 : MaterialForm
	{
		public Form1()
		{
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey900, Primary.Grey900, Accent.LightGreen700, TextShade.WHITE);
		}

		private void MaterialFlatButton1_Click(object sender, EventArgs e)
		{
			string dict = "";
			if (materialCheckBox1.Checked)
			{
				dict += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			}
			if (materialCheckBox2.Checked)
			{
				dict += "abcdefghijklmnopqrstuvwxyz";
			}
			if (materialCheckBox3.Checked)
			{
				dict += "0123456789";
			}
			if (materialCheckBox4.Checked)
			{
				dict += "!#$%&()*+-.=?@_";
			}
			else
			{
				dict += "0";
			}
			Random random = new Random();
			string pass = "";
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < numericUpDown1.Value; j++)
				{
					int index = Convert.ToInt16(random.NextDouble() * dict.Length) % dict.Length;
					char SymChar = dict[index];
					pass += Convert.ToString(SymChar);
				}
				richTextBox1.Text = pass += "\n";
			}
		}
	}
}
