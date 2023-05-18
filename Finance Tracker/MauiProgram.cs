using Finance_Tracker.Services;
using Finance_Tracker.Services.UserService;
using Finance_Tracker.ViewModels;
using Finance_Tracker.Views;

namespace Finance_Tracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddTransient<LoginView>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<SignUpView>();
        builder.Services.AddTransient<SignUpViewModel>();

        builder.Services.AddSingleton<UserService>();

        return builder.Build();
	}
}
