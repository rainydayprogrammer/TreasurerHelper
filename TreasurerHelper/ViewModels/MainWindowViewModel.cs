using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;
using TreasurerHelper.Infrastructure;

namespace TreasurerHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;


        private string _title = "会計係支援システム";
        private bool _mainMenuIsOpen = false;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
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
            MainMenuIsOpen = false;

            if (navigatePath != null)
                _regionManager.RequestNavigate(RegionNames.ContentRegion, navigatePath);
       
        }
    }
 }
