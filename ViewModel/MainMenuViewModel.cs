using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GmoUIMaui.View;
using GmoUIMaui.View.Desktop;
using GmoUIMaui.View.Mobile;

namespace GmoUIMaui.ViewModel;

public class MainMenuViewModel : BaseViewModel
{
    public MainMenuViewModel()
    {
        Title = "Main Menu";

        GoToTempViewCommand = new RelayCommand(GoToTempView);
        GoToProfile1ViewCommand = new RelayCommand(GoToProfile1View);
    }
    
    public RelayCommand GoToTempViewCommand { get; private set; }
    public RelayCommand GoToProfile1ViewCommand { get; private set; }

    private static void GoToTempView()
    {
        Shell.Current.GoToAsync(nameof(tempView), true);
    }

    private static void GoToProfile1View()
    {
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone) 
            Shell.Current.GoToAsync(nameof(Profile1MobileView), true);
        else
            Shell.Current.GoToAsync(nameof(Profile1DesktopView), true);
    }
}