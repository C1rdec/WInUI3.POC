using Microsoft.UI.Xaml.Controls;
using WinUI3.POC.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3.POC.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class HelloWorldPage : Page
{
    public HelloWorldPage()
    {
        DataContext = App.GetService<HelloWorldViewModel>();
        InitializeComponent();
    }
}
