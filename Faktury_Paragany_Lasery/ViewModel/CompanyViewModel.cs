using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Faktury_Paragany_Lasery.ViewModel
{
    using Models;
    using Commands;
    using System.Runtime.CompilerServices;

    public class CompanyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Company> CurrentCompanies
        {
            get
            {
                return new ObservableCollection<Company>(){new Company() { name = "RAkieta", nip = 123456789, address = "Polna 31, Bielsko-Biala" },
                new Company() { name = "Auto", nip = 987654321, address = "Caasdasd 8/3, Wrocal" } };
            }
        }

        public void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public CompanyViewModel() { }
    }
}
