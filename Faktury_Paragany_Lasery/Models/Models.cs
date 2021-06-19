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
    class Models
    {

        public ObservableCollection<Company> Companies { get; set; } = new ObservableCollection<Company>();
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public Models()
        {
            var companies = RepositoryCompanies.GetAllCompanies();
            foreach (var c in companies)
                Companies.Add(c);
            /*
            var products = RepositoryProducts.GetAll();
            foreach (var p in products)
                Products.Add(p);*/
        }

        public bool DeleteCompany(Company company)
        { 
            bool state = RepositoryCompanies.DeleteCompanyFromDB(company);
            if (state == true) 
                Companies.Remove(company);
            return state;
        }

        private Company FindByNIP(string nip)
        {
            foreach (var c in Companies)
                if (c.Nip == nip) return c;
            return null;
        }
    }
}
