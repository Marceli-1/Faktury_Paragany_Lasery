using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.ViewModel
{
    using Models;
    using DAL.Entities;
    using System.Collections.ObjectModel;
    using Commands;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    class CompanyViewModel : BaseViewModel 
    {
        #region private attributes
        private CompanyModel model = new CompanyModel();
        private ObservableCollection<Company> companies = null;
        private int idClickedCompany = -1;
        #endregion

        #region Constructors
        public CompanyViewModel()
        {
            companies = model.Companies;
        }
        #endregion

        #region Properties
        public int IdClickedCompany
        {
            get => idClickedCompany;
            set
            {
                idClickedCompany = value;
                onPropertyChanged(nameof(IdClickedCompany));
            }
        }
        public Company CurrentCompany { get; set; }
        public ObservableCollection<Company> Companies
        {
            get { return companies; }
            set
            {
                companies = value;
                onPropertyChanged(nameof(Companies));
            }
        }
        #endregion

        #region Methods
        public void RefreshCompanies() => Companies = model.Companies;
        #endregion

        #region Commands
        private ICommand loadCompanies = null;
        public ICommand LoadCompanies
        {
            get
            {
                if (loadCompanies == null)
                    loadCompanies = new RelayCommand(
                        arg =>
                        {
                            Companies = model.Companies;
                            IdClickedCompany = -1;
                        },
                        arg => true
                        );
                return loadCompanies;
            }
        }
        #endregion
    }
}
