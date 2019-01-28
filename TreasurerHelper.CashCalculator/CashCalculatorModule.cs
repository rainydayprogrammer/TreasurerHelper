using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper.CashCalculator
{
    public class CashCalculatorModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.CashCalculator));

            var menuService = containerProvider.Resolve<IMenuService>();
            menuService.AddMainMenuItem(new MenuItem { Title = "現金計算", IconName = "Calculator", Description = "紙幣・硬貨毎の枚数入力",
                NavigatePath = "TreasurerHelper.CashCalculator.Views.CashCalculator",
                DisplayOnHome = true,
                ImageSource = "pack://application:,,,/TreasurerHelper.CashCalculator;component/Resources/CashCalculator.jpg"
            });
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}