using Finance_Tracker.ViewModels;

namespace Finance_Tracker;

public partial class MainPage : ContentPage
{


	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}


}

