using Microsoft.UI.Xaml.Controls;

using WinUI3.POC.ViewModels;

namespace WinUI3.POC.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        DataContext = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
