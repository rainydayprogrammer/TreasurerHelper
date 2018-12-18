using Prism.Mvvm;

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

        public MainWindowViewModel()
        {

        }
    }
}
