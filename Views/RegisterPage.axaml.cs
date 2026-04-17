using Avalonia.Controls;
using Avalonia.Interactivity;
using Logistics.Views.DriverHomePage;
using Logistics.Views.LogistHomePage;

namespace Logistics.Views;

public partial class RegisterPage : UserControl
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void RoleChanged(object? sender, RoutedEventArgs e)
    {
        LogistPanel.IsVisible = Logist.IsChecked == true;
        DriverPanel.IsVisible = Driver.IsChecked == true;
    }

    private void RegisterClick(object? sender, RoutedEventArgs e)
    {
        if (Logist.IsChecked == true)
        {
            MainWindow.MainFrameInstance.Content = new LogistHome();
        }
        else if (Driver.IsChecked == true)
        {
            
            MainWindow.MainFrameInstance.Content = new DriverHome();
        }
    }
}