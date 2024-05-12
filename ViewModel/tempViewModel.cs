using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GmoUIMaui.ViewModel;

public class tempViewModel : BaseViewModel, INotifyPropertyChanged
{
    public tempViewModel()
    {
        Title = "temp view";
    }
    
    
    public new event PropertyChangedEventHandler? PropertyChanged;
}