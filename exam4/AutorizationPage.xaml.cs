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
	/// Логика взаимодействия для AutorizationPage.xaml
	/// </summary>
	public partial class AutorizationPage : Page
	{
		public AutorizationPage()
		{
			InitializeComponent();
		}

		private void Entry_Click(object sender, RoutedEventArgs e)
		{
			string? login = Login.Text.ToString();
			string? password = Password.Password.ToString();
			if (login =="admin" && password == "admin")
			{
				Manager.MainFrame.Navigate(new FirstExamplePage());
			}
			else
			{
				ErrorText.Text = "Неверно введен  логин или пароль";
			}
        }
    }
}
