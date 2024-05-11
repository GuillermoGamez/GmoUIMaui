using GmoUIMaui.View;
using GmoUIMaui.ViewModel;
using Microsoft.Extensions.Logging;

namespace GmoUIMaui;

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

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        // views
        builder.Services.AddSingleton<MainMenuView>();
        
        // view models
        builder.Services.AddSingleton<MainMenuViewModel>();

        return builder.Build();
    }
}