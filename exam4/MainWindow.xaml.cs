using System.Text;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Manager.MainFrame = MainFrame;
			MainFrame.Navigate(new AutorizationPage());
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			if (Manager.MainFrame.CanGoBack)
			{
				Manager.MainFrame.GoBack();
			}
			
        }
    }
}