using Prism.Mvvm;
using System.Collections.Generic;
using TreasurerHelper.CashCalculator.Models;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System;

namespace TreasurerHelper.CashCalculator.ViewModels
{
    public class CashCalculatorViewModel : BindableBase
    {
        private decimal _bankBalance ;
        public decimal BankBalance
        {
            get { return _bankBalance; }
            set {
                SetProperty(ref _bankBalance, value);
                RaisePropertyChanged(nameof(Balance));
            }
        }

        public decimal Balance
        {
            get { return BankBalance + GrandTotal; }
        }

        public ICollectionView CountItems { get; private set; }


        public decimal GrandTotal
        {
            get { return CountItems.OfType<CountItem>().Sum(m => m.AmountByType); }
        }

        public CashCalculatorViewModel()
        {
            CountItems = new ListCollectionView(new ObservableCollection<CountItem> {
                new CountItem{MoneyType = "1円", MondeyValue = 1, MoneyCount = 0 },
                new CountItem{MoneyType= "5円", MondeyValue = 5, MoneyCount = 0},
                new CountItem{MoneyType= "10円", MondeyValue = 10, MoneyCount = 0},
                new CountItem{MoneyType= "50円", MondeyValue = 50, MoneyCount = 0},
                new CountItem{MoneyType= "100円", MondeyValue = 100, MoneyCount = 0},
                new CountItem{MoneyType= "500円", MondeyValue = 500, MoneyCount = 0},
                new CountItem{MoneyType= "1,000円", MondeyValue = 1000, MoneyCount = 0},
                new CountItem{MoneyType= "5,000円", MondeyValue = 5000, MoneyCount = 0},
                new CountItem{MoneyType= "10,000円", MondeyValue = 10000, MoneyCount = 0}
            });

            CountItems.CurrentChanged += SelectedItemChanged;
        }

        private void SelectedItemChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged(nameof(GrandTotal));
            RaisePropertyChanged(nameof(Balance));
        }
    }
}
