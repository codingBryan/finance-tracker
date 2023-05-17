using CommunityToolkit.Mvvm.Input;
using Finance_Tracker.Services.UserService;
using Finance_Tracker.Views;

namespace Finance_Tracker.ViewModels
{
    public partial class LoginViewModel:BaseViewModel
    {
        protected readonly IUserRepository userService;
        public LoginViewModel(IUserRepository userService)
        {
            this.userService = userService;
        }
        [RelayCommand]
        async Task GoToSignUp()
        {
            await Shell.Current.GoToAsync(nameof(SignUpView));
        }
        
        
    }
}
