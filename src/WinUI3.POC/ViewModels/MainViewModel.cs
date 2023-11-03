using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3.POC.Contracts.Services;

namespace WinUI3.POC.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    public void Go() => App.GetService<INavigationService>().NavigateTo<HelloWorldViewModel>();
}
