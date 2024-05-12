namespace GmoUIMaui.Model;

public class MyStyle
{
    public Color ButtonBackGroundColor { get; set; } = Colors.MediumBlue;
    public Color ButtonTextColor { get; set; } = Colors.White;
    
    private readonly Random _random = new Random();
    
    public void RandomTheme()
    {
        ButtonBackGroundColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256)); 
        ButtonTextColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
    }
}