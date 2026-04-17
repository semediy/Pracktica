using Avalonia.Controls;
using Avalonia.Interactivity;
using Logistics.Views.LogistHomePage;
using Logistics;
using Logistics.Views;


namespace Logistiсs.Views;

public partial class LoginPage : UserControl
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void LoginClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.MainFrameInstance.Content = new LogistHome();
    }
}