using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

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

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            MainMenuIsOpen = false;

            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
       
        }
    }
 }
