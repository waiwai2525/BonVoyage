using System.Windows;
using BonVoyage.Platforms.WpfApp.Views;
using Prism.Ioc;
using Prism.Mvvm;

namespace BonVoyage.Platforms.WpfApp;

public partial class App
{
    protected override void ConfigureViewModelLocator()
    {
        base.ConfigureViewModelLocator();

        ViewModelLocationProvider.Register<MainWindowView, MainWindowViewModel>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    protected override Window CreateShell()
    {
        return Container.Resolve<MainWindowView>();
    }
}
