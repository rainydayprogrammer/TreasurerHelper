using Prism.Mvvm;

namespace TreasurerHelper.Cashbook.ViewModels
{
    public class CashbookViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public CashbookViewModel()
        {
            Message = "View A from Cashbook Module";
        }
    }
}
