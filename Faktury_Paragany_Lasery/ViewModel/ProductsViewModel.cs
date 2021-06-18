using Faktury_Paragany_Lasery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.ViewModel
{
    using Models;
    using Commands;
    using System.Runtime.CompilerServices;

    public class ProductsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; 

        public ObservableCollection<Products> CurrentProduct
        {
            get
            {
                return new ObservableCollection<Products>(){new Products() { name = "cukierek", volume = 12 },
                    new Products() { name = "Auto", volume = 1 } };
            }
        }

        public void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductsViewModel() { }
    }
}

