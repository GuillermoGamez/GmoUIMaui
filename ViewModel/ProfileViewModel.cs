using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GmoUIMaui.ViewModel;

public class ProfileViewModel : BaseViewModel, INotifyPropertyChanged
{
    public ProfileViewModel()
    {
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
            Title = "Profile Mobile View";
        else
            Title = "Profile Tablet/Desktop View";
        
        RandomThemeCommand = new RelayCommand(RandomTheme);
    }
    
    public new event PropertyChangedEventHandler? PropertyChanged;
    
    public RelayCommand RandomThemeCommand { get; private set; }

    private void RandomTheme()
    {
        MyStyle.RandomTheme();
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyStyle)));
    }
}