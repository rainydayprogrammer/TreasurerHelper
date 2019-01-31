using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using TreasurerHelper.Infrastructure;
using System.Linq;

namespace TreasurerHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;


        private string _title = "会計係支援システム";
        private string _moduleTitle = "Home";
        private bool _mainMenuIsOpen = false;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ModuleTitle
        {
            get { return _moduleTitle; }
            set { SetProperty(ref _moduleTitle, value); }
        }

        public bool MainMenuIsOpen
        {
            get { return _mainMenuIsOpen; }
            set { SetProperty(ref _mainMenuIsOpen, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }
        public List<MenuItem> MainMenuItems { get; set; }


        public MainWindowViewModel(IRegionManager regionManager, IMenuService menuService)
        {
            _regionManager = regionManager;

            MainMenuItems = menuService.GetMainMenuItems();
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {

            if (navigatePath != null)
                _regionManager.RequestNavigate(RegionNames.ContentRegion, navigatePath, NavigationComplete);
       
        }

        private void NavigationComplete(NavigationResult result)
        {
            MainMenuIsOpen = false;
            ModuleTitle = MainMenuItems.Where(m => m.NavigatePath == result.Context.Uri.ToString()).FirstOrDefault().Title;
        }
    }
}
