using Prism.Mvvm;

namespace TreasurerHelper.CashCalculator.ViewModels
{
    public class CashCalculatorViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public CashCalculatorViewModel()
        {
            Message = "CashCalculator View from your Prism Module";
        }
    }
}
