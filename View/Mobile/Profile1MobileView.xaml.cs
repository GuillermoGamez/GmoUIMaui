using GmoUIMaui.ViewModel;

namespace GmoUIMaui.View.Mobile;

public partial class Profile1MobileView : ContentPage
{
    public Profile1MobileView(ProfileViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}