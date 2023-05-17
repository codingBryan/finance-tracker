using CommunityToolkit.Mvvm.Input;
using Finance_Tracker.Models;
using Finance_Tracker.Services.UserService;
using Finance_Tracker.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker.ViewModels
{
    public partial class SignUpViewModel:BaseViewModel
    {
        protected readonly IUserRepository userService;
        public SignUpViewModel(IUserRepository userService)
        {
            this.userService = userService;
        }
        [RelayCommand]
        async Task GoToLogin() 
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task Register(User user)
        {
            User newUser;
            try
            {
                newUser = await userService.AddUpdateUser(user);
                Debug.WriteLine(newUser.username);
            }catch(Exception ex) 
            {
                await Shell.Current.GoToAsync(nameof(LoginView));
            }
        }
    }
}
