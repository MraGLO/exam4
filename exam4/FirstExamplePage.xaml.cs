using ExamClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exam4
{
	/// <summary>
	/// Логика взаимодействия для FirstExamplePage.xaml
	/// </summary>
	public partial class FirstExamplePage : Page
	{
		Examples examples = new Examples();
		public FirstExamplePage()
		{
			InitializeComponent();
		}

		private void Entry_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double x = Convert.ToDouble(Number.Text.ToString());
				double xx = examples.ExampleFirst(x);
				Result.Text = xx.ToString();
			}
			catch
			{
				Result.Text = "Вы ввели не число";
			}
			
        }
    }
}
