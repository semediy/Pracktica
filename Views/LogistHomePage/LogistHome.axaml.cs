using Avalonia.Controls;
using Avalonia.Interactivity;
using Logistics.Views.LogistHomePage;

namespace Logistics.Views.LogistHomePage;

public partial class LogistHome : UserControl
{
    public LogistHome()
    {
        InitializeComponent();
        
        ContentArea.Content = new TransportationsPage();
       
    }

    private void OpenTransport(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new TransportationsPage();
    }

    private void OpenDrivers(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new DriversPage();
    }

    private void OpenRoutes(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new RoutesPage();
    }

    private void OpenVehicles(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new VehiclesPage();
    }

    private void OpenCalendar(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new CalendarPage();
    }

    private void OpenSettings(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new SettingsPage();
    }
    private void OpenContactDrivers(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new ContactDrivers();
    }
    
    private void OpenInternational(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new InternationalPage();
    }
    
    private void OpenAdmin(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new AdminPage();
    }
}