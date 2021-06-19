using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Faktury_Paragany_Lasery.DAL.Entities
{
    class Company
    {
        #region Properties
        public string Name { get; set; }
        public string Address { get; set; }

        [StringLength(100)]
        public string Nip { get; set; }
        //public ObservableCollection<Company> Company { get; internal set; }
        #endregion

        #region Constructors
        public Company(string name, string nip, string address)
        {
            Name = name.Trim();
            Nip = nip.Trim();
            Address = address.Trim();
        }

        public Company(Company company)
        {
            Name = company.Name;
            Nip = company.Nip;
            Address = company.Address;
        }

        public Company(MySqlDataReader reader)
        {
            Name = reader["name"].ToString();
            Nip = reader["nip"].ToString();
            Address = reader["address"].ToString();
            Console.WriteLine("Jest maly problem ale ni tu");
        }
        #endregion


        #region Methods
        public string ToInsert() => $"('{Name}', '{Nip}', '{Address}')";

        public override bool Equals(object obj)
        {
            var company = obj as Company;
            if (company is null) return false;
            if (Nip == company.Nip) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
