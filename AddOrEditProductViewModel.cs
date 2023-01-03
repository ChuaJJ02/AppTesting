using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App2
{
    public class AddOrEditProductViewModel: INotifyPropertyChanged
    {
        public ProductInfo _productInfo;
        public ProductInfo Product
        {
            get { return _productInfo; }
            set { _productInfo = value;
                OnPropertyChanged();
            }
        }
        public AddOrEditProductViewModel()
        {
            Product = new ProductInfo();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
