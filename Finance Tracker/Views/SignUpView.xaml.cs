using Finance_Tracker.ViewModels;

namespace Finance_Tracker.Views;

public partial class SignUpView : ContentPage
{
	public SignUpView(SignUpViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}