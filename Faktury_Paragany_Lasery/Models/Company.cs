using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.Models
{
    using DAL.Entities;
    using DAL.Repositories;
    using System.Collections.ObjectModel;
    class CompanyModel
    {

        public ObservableCollection<Company> Companies { get; set; } = new ObservableCollection<Company>();

        public CompanyModel()
        {
            var companies = RepositoryCompanies.GetAllCompanies();
            foreach (var c in companies)
                Companies.Add(c);
        }

        public bool DeleteCompany(Company company) => RepositoryCompanies.DeleteCompanyFromDB(company);

        private Company FindByNIP(string nip)
        {
            foreach (var c in Companies)
                if (c.Nip == nip) return c;
            return null;
        }
    }
}
