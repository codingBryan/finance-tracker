using CommunityToolkit.Mvvm.ComponentModel;
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
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;
        protected readonly IUserRepository userService = new UserService();
        
        [RelayCommand]
        async Task GoToLogin() 
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task Register()
        {
            User newUser = new User()
            {
                email = email,
                username = username,
                password = password
            };
            try
            {
                await userService.Register(newUser);
                await Shell.Current.GoToAsync(nameof(LoginView));
            }
            catch(Exception ex) 
            {
                
            }
        }
    }
}
