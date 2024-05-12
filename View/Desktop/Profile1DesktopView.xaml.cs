using GmoUIMaui.ViewModel;

namespace GmoUIMaui.View.Desktop;

public partial class Profile1DesktopView : ContentPage
{
    public Profile1DesktopView(ProfileViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}