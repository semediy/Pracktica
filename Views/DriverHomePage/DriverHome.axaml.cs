using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Logistics.Views.LogistHomePage;

namespace Logistics.Views.DriverHomePage;

public partial class DriverHome : UserControl
{
    public DriverHome()
    {
        InitializeComponent();
    }
    private void OpenCalendar(object? sender, RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new CalendarPage();
    }
    private void OpenAvailableRoutes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = null;
        ContentArea.Content = new AvailableRoutes();
    }
     private void OpenContactLogist(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ContentArea.Content = null;
            ContentArea.Content = new ContactLogist();
        }
}