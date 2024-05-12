namespace GmoUIMaui.ViewModel;

public class ProfileViewModel : BaseViewModel
{
    public ProfileViewModel()
    {
        if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
            Title = "Profile Mobile View";
        else
            Title = "Profile Tablet/Desktop View";
    }
}