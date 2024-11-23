using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace SpotifyNavBar.Components;

public partial class SearchInput : UserControl
{
    public SearchInput()
    {
        InitializeComponent();
    }
    private void UserControl_GotFocus(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        searchIcon.Stroke=new SolidColorBrush(Colors.White);

    }
    private void UserControl_LostFocus(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        searchIcon.Stroke=new SolidColorBrush(Color.FromArgb(30,255,255,255));
    }

}