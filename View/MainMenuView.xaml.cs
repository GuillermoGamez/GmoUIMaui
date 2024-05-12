using GmoUIMaui.View.Desktop;
using GmoUIMaui.View.Mobile;
using GmoUIMaui.ViewModel;

namespace GmoUIMaui.View;

public partial class MainMenuView : ContentPage
{
    public MainMenuView(MainMenuViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        
        Routing.RegisterRoute(nameof(tempView), typeof(tempView));
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
        {
            Routing.RegisterRoute(nameof(Profile1MobileView), typeof(Profile1MobileView)); 
        }
        else
        {
            Routing.RegisterRoute(nameof(Profile1DesktopView), typeof(Profile1DesktopView));
        }
        
    }
}