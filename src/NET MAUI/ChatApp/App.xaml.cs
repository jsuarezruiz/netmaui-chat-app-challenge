using ChatApp.Views;

namespace ChatApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new DetailView());//new HomeView());
	}
}