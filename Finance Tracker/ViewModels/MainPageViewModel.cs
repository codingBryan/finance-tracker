using CommunityToolkit.Mvvm.Input;
using Finance_Tracker.Views;

namespace Finance_Tracker.ViewModels
{
    public partial class MainPageViewModel:BaseViewModel
    {
        [RelayCommand]
        async Task GoToLogin()
        {
            await Shell.Current.GoToAsync(nameof(LoginView));
        }
    }
}
