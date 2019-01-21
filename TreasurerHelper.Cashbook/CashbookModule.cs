using TreasurerHelper.Cashbook.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper.Cashbook
{
    public class CashbookModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.Cashbook));

            var menuService = containerProvider.Resolve<IMenuService>();
            menuService.AddMainMenuItem(new MenuItem { Title = "出納帳", IconName = "BookOpenVariant", Description = "入金・出金の記録",
                NavigatePath = "TreasurerHelper.Cashbook.Views.Cashbook",
                DisplayOnHome = true,
                ImageSource = "pack://application:,,,/TreasurerHelper;component/Resources/CashBook.jpg"
            });

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}