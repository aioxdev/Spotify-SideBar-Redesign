using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using System;

namespace SpotifyNavBar.Components;

public partial class MusicPanel : UserControl
{
    public int previousValue { get; set; } = 0;

    public MusicPanel()
    {
        InitializeComponent();
    }

    private void ToggleButton_Checked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ToggleButton button= sender as ToggleButton;
        previousValue = (int)soundSlider.Value;
        soundSlider.Value = 0;
    }

    private void ToggleButton_Unchecked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ToggleButton button= sender as ToggleButton;
        soundSlider.Value = previousValue;
    }
}