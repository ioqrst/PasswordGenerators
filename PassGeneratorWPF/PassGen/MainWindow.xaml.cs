using System;
using System.Windows;
using System.Windows.Input;

namespace PassGen
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string dict = "";
			textBox1.Document.Blocks.Clear();

			if (checkBox1.IsChecked ?? false)
			{
				dict += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			}
			if (checkBox2.IsChecked ?? false)
			{
				dict += "abcdefghijklmnopqrstuvwxyz";
			}
			if (checkBox3.IsChecked ?? false)
			{
				dict += "0123456789";
			}
			if (checkBox4.IsChecked ?? false)
			{
				dict += "!#$%&()*+-.=?@_";
			}
			else
			{
				dict += "0";
			}

			Random random = new Random();
			string pass = "";
			try
			{
				for (int i = 0; i < 18; i++)
				{
					for (int j = 0; j < Convert.ToInt16(NumUpDown.Text); j++)
					{
						int index = Convert.ToInt16(random.NextDouble() * dict.Length) % dict.Length;
						char SymChar = dict[index];
						pass += Convert.ToString(SymChar);
					}
					textBox1.AppendText(pass + "\r");
					pass = "";
				}
			}
			catch (System.FormatException ex)
			{
				textBox1.AppendText("Enter a value in the Password Length field.");
			}
			
		}

		private void NumUpDown_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !(Char.IsDigit(e.Text, 0));
		}
	}
}
