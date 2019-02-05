using Prism.Mvvm;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreasurerHelper.Infrastructure.Models
{
    public abstract class DomainObject : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        // https://raw.githubusercontent.com/jorik041/prism/master/V4/Quickstarts/MVVM/MVVM/Infrastructure/DomainObject.cs
        private ErrorsContainer<string> errorsContainer;

        protected DomainObject()
        {
        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // INotifyDataErrorInfo
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public bool HasErrors
        {
            get { return this.ErrorsContainer.HasErrors; }
        }

        protected ErrorsContainer<string> ErrorsContainer
        {
            get
            {
                if (this.errorsContainer == null)
                {
                    this.errorsContainer =
                        new ErrorsContainer<string>(pn => this.RaiseErrorsChanged(pn));
                }

                return this.errorsContainer;
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return this.ErrorsContainer.GetErrors(propertyName);
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            this.PropertyChanged?.Invoke(this, e);
        }

        protected virtual void ValidateProperty(string propertyName, object value)
        {
        }

        protected void RaiseErrorsChanged(string propertyName)
        {
            this.OnErrorsChanged(new DataErrorsChangedEventArgs(propertyName));
        }

        protected virtual void OnErrorsChanged(DataErrorsChangedEventArgs e)
        {
            this.ErrorsChanged?.Invoke(this, e);
        }
    }
}
