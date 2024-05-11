using GmoUIMaui.ViewModel;

namespace GmoUIMaui.View;

public partial class MainMenuView : ContentPage
{
    public MainMenuView(MainMenuViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}