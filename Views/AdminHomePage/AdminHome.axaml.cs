using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Logistics.Views.DriverHomePage;
using Logistics.Views.LogistHomePage;
using Logistics.Views.UserHomePage;

namespace Logistics.Views.AdminHomePage;

public partial class AdminHome : UserControl
{
    public AdminHome()
    {
        InitializeComponent();
    }
    private void OpenContactLogist(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new ContactLogist();
    }
    private void OpenUser(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new UserHome();
    }
    private void OpenSettings(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new SettingsPage();
    }
    private void OpenChange(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new ChangePage();
    }
    private void OpenLogist(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new LogistHome();
       
    }

    private void OpenDrivers(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new DriverHome();
       
    }
}