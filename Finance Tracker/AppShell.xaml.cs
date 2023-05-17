using Finance_Tracker.Views;

namespace Finance_Tracker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginView),typeof(LoginView));
        Routing.RegisterRoute(nameof(SignUpView), typeof(SignUpView));
        Routing.RegisterRoute(nameof(IncomeView), typeof(IncomeView));
        Routing.RegisterRoute(nameof(ExpenseView), typeof(ExpenseView));
    }
}
