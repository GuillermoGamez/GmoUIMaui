using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GmoUIMaui.Model;

namespace GmoUIMaui.ViewModel;

public abstract class BaseViewModel : ObservableObject, INotifyPropertyChanged
{
    protected BaseViewModel()
    {
        RandomThemeCommand = new RelayCommand(RandomTheme);
        DefaultThemeCommand = new RelayCommand(DefaultTheme);
        GetThemeCommand = new RelayCommand(GetTheme);
    }
    
    public RelayCommand RandomThemeCommand { get; private set; }
    public RelayCommand DefaultThemeCommand { get; private set; }
    public RelayCommand GetThemeCommand { get; private set; }
    
    public string Title { get; set; } = "";
    public new event PropertyChangedEventHandler? PropertyChanged;
    public MyStyle MyStyle { get; init; } = new MyStyle();
    
    private void GetTheme()
    {
        Shell.Current.DisplayAlert("Theme Information", MyStyle.ThemeInfo, "Confirm");
    }
    
    private void RandomTheme()
    {
        MyStyle.RandomTheme();
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyStyle)));
    }
    private void DefaultTheme()
    {
        MyStyle.DefaultTheme();
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyStyle)));
    }
}