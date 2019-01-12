using Home.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.ViewA));
            regionManager.RegisterViewWithRegion("MainNavigationRegion", typeof(HomeItemView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}