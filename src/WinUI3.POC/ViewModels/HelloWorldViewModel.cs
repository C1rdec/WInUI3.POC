using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3.POC.Contracts.Services;

namespace WinUI3.POC.ViewModels;

public partial class HelloWorldViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "Hello World";

    [RelayCommand]
    public void GoBack() => App.GetService<INavigationService>().GoBack();
}
