using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Finance_Tracker.Models;
using Finance_Tracker.Services.UserService;
using Finance_Tracker.Views;
using Newtonsoft.Json;

namespace Finance_Tracker.ViewModels
{
    public partial class LoginViewModel:BaseViewModel
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        readonly IUserRepository userService = new UserService();

        [RelayCommand]
        async Task GoToSignUp()
        {
            await Shell.Current.GoToAsync(nameof(SignUpView));
        }

        [RelayCommand]
        async Task Login()
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var user = await userService.Login(username, password);
                if(user != null)
                {
                    await Shell.Current.GoToAsync(nameof(Dashboard));
                }
                await Shell.Current.DisplayAlert("Error", "Incorrect credentials", "OK");
                
            }
        }


    }
}
