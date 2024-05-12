using CommunityToolkit.Mvvm.ComponentModel;
using GmoUIMaui.Model;

namespace GmoUIMaui.ViewModel;

public abstract class BaseViewModel : ObservableObject
{
    public string Title { get; set; } = "";
    public bool IsBusy { get; set; }
    public MyStyle MyStyle { get; set; } = new MyStyle();

}