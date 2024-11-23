using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace SpotifyNavBar.Components;

public partial class Navigation : UserControl
{
    public Navigation()
    {
        InitializeComponent();
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        
    }

    private void ToggleButton_Checked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ToggleButton button=(ToggleButton)sender;

        foreach(ToggleButton item in navItems.Children)
        {
            if (item != button)
            {
                item.IsChecked = false;
                item.IsEnabled = true;
            }
        };

        pointer.Margin=new Thickness(0,button.Bounds.Top+5,0,0);
    }


}