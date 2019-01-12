using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace TreasurerHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "会計係支援システム";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }
        private IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("MainContentRegion", navigatePath);
        }
    }
 }
