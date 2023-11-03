namespace WinUI3.POC.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
