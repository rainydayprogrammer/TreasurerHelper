using CashCalculator.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreasurerHelper.Infrastructure;

namespace CashCalculator
{
    public class CashCalculatorModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.CashCalculator));

            var menuService = containerProvider.Resolve<IMenuService>();
            menuService.AddMainMenuItem(new MenuItem { Title = "現金計算", IconName = "Calculator", Description = "紙幣・硬貨毎の枚数入力", NavigatePath = "CashCalculator.Views.CashCalculator" });
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}