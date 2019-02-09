using Prism.Mvvm;
using System.Collections.Generic;
using TreasurerHelper.CashCalculator.Models;

namespace TreasurerHelper.CashCalculator.ViewModels
{
    public class CashCalculatorViewModel : BindableBase
    {
        public List<CountItem> CountItems { get; set; }

        public CashCalculatorViewModel()
        {
            CountItems = new List<CountItem> {
                new CountItem{MoneyType = "1円", MondeyValue = 1, MoneyCount = 0 },
                new CountItem{MoneyType= "5円", MondeyValue = 5, MoneyCount = 0},
                new CountItem{MoneyType= "10円", MondeyValue = 10, MoneyCount = 0},
                new CountItem{MoneyType= "50円", MondeyValue = 50, MoneyCount = 0},
                new CountItem{MoneyType= "100円", MondeyValue = 100, MoneyCount = 0},
                new CountItem{MoneyType= "500円", MondeyValue = 500, MoneyCount = 0},
                new CountItem{MoneyType= "1,000円", MondeyValue = 1000, MoneyCount = 0},
                new CountItem{MoneyType= "5,000円", MondeyValue = 5000, MoneyCount = 0},
                new CountItem{MoneyType= "10,000円", MondeyValue = 10000, MoneyCount = 0}
            };
        }
    }
}
