using GmoUIMaui.ViewModel;

namespace GmoUIMaui.View;

public partial class tempView : ContentPage
{
    public tempView(tempViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}