using Home.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreasurerHelper.Infrastructure;

namespace Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.ViewA));

            var menuService = containerProvider.Resolve<IMenuService>();
            menuService.AddMainMenuItem(new MenuItem { Title = "ホーム", IconName = "Home", Description = "テスト用", NavigatePath = "Home.Views.ViewA" });
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}