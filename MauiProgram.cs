using GmoUIMaui.View;
using GmoUIMaui.View.Desktop;
using GmoUIMaui.View.Mobile;
using GmoUIMaui.ViewModel;
using MauiIcons.Fluent;
using Microsoft.Extensions.Logging;

namespace GmoUIMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseFluentMauiIcons()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        // views
        builder.Services.AddSingleton<MainMenuView>();
        builder.Services.AddSingleton<tempView>();

        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
        {
            builder.Services.AddSingleton<Profile1MobileView>();
        }
        else
        {
            builder.Services.AddSingleton<Profile1DesktopView>();   
        }
        
        // view models
        builder.Services.AddSingleton<MainMenuViewModel>();
        builder.Services.AddSingleton<tempViewModel>();
        builder.Services.AddSingleton<ProfileViewModel>();

        return builder.Build();
    }
}