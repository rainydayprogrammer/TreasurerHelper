﻿using CashCalculator.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CashCalculator
{
    public class CashCalculatorModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.CashCalculator));
            regionManager.RegisterViewWithRegion("MainNavigationRegion",typeof(Views.CashCalculatorNavigationItemView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}