using CommunityToolkit.Mvvm.ComponentModel;

namespace GmoUIMaui.ViewModel;

public abstract class BaseViewModel : ObservableObject
{
    public string Title { get; set; } = "";
    public bool IsBusy { get; set; }
}