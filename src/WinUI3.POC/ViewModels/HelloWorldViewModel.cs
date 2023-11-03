using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3.POC.Contracts.Services;

namespace WinUI3.POC.ViewModels;

public partial class HelloWorldViewModel : ObservableRecipient
{
    public string Title => "Hello World";

    [RelayCommand]
    public void GoBack() => App.GetService<INavigationService>().GoBack();
}
