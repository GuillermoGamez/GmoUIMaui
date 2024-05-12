namespace GmoUIMaui.Model;

public class MyStyle
{
    public Color ButtonBgColor { get; set; } = Colors.MediumBlue;
    public Color ButtonTextColor { get; set; } = Colors.White;
    public Color GridHeaderBgColor { get; set; } = Colors.Navy;
    public Color GridBodyBgColor { get; set; } = Colors.Transparent;
    public Color LabelTextColor { get; set; } = Colors.White;
    public Color BorderColor { get; set; } = Colors.Black;
    public Color BorderBgColor { get; set; } = Colors.White;

    public string ThemeInfo =>
        $"Button BG Color: {ButtonBgColor.ToHex()} \n" +
        $"Button Text Color: {ButtonTextColor.ToHex()} \n" +
        $"Grid Header BG Color: {GridHeaderBgColor.ToHex()} \n" +
        $"Grid Body BG Color: {GridBodyBgColor.ToHex()} \n" +
        $"Label Text Color: {LabelTextColor.ToHex()} \n" +
        $"Border Color: {BorderColor.ToHex()} \n" +
        $"Border BG Color: {BorderBgColor.ToHex()}";

    private readonly Random _random = new Random();
    
    public void RandomTheme()
    {
        ButtonBgColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256)); 
        ButtonTextColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        GridHeaderBgColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        GridBodyBgColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        LabelTextColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        BorderColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
        BorderBgColor = Color.FromRgb(_random.Next(256), _random.Next(256), _random.Next(256));
    }

    public void DefaultTheme()
    {
        ButtonBgColor = Colors.MediumBlue;
        ButtonTextColor = Colors.White;
        GridHeaderBgColor = Colors.Navy;
        GridBodyBgColor = Colors.Transparent;
        LabelTextColor = Colors.White;
        BorderColor = Colors.Black;
        BorderBgColor = Colors.White;
    }
}