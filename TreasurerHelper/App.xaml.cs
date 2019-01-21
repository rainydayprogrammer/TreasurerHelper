using TreasurerHelper.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMenuService, MenuService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Home.HomeModule>();
            moduleCatalog.AddModule<CashCalculator.CashCalculatorModule>();
            moduleCatalog.AddModule<Cashbook.CashbookModule>();
        }
    }
}
