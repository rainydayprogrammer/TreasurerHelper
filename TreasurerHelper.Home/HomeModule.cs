using TreasurerHelper.Home.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper.Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.HomeMenu));

            var menuService = containerProvider.Resolve<IMenuService>();
            menuService.AddMainMenuItem(new MenuItem { Title = "新ホーム", IconName = "Home", Description = "テスト用", NavigatePath = "TreasurerHelper.Home.Views.HomeMenu", DisplayOnHome = false });
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}