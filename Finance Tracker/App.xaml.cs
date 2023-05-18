using Finance_Tracker.Models;

namespace Finance_Tracker;

public partial class App : Application
{
    public static User user;
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
