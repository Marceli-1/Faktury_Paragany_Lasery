using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.ViewModel
{
    using DAL;
    using Models;
    using Commands;
    class MainViewModel
    {
        private CompanyModel companyModel = new CompanyModel();
        
        public CompanyViewModel CompanyVM { get; set; }

        public MainViewModel()
        {
            CompanyVM = new CompanyViewModel(companyModel);
        }

    }
}
