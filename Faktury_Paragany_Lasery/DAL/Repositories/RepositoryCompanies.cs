using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Faktury_Paragany_Lasery.DAL.Repositories
{
    using Entities;
    class RepositoryCompanies
    {
        #region Queries strings
        private const string ALL_COMPANIES = "SELECT * FROM companies";
        private const string ADD_COMPANY = "INSERT INTO `companies` (`name`, `nip`, `address`) VALUES ";
        #endregion

        #region CRUD
        public static List<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(ALL_COMPANIES, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    companies.Add(new Company(reader));
                connection.Close();
            }
            Console.WriteLine("LUL TO DZIALA");
            return companies;
        }

        public static bool AddCompanyToDB(Company company)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{ADD_COMPANY} {company.ToInsert()}", connection);
                connection.Open();
                var id = command.ExecuteNonQuery();
                state = true;
                company.Id = (sbyte)command.LastInsertedId;
                connection.Close();
            }
            return state;
        }

        public static bool EditCompanyInDB(Company company, sbyte CompanyID)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string EDIT_COMPANY = $"UPDATE companies SET name='{company.Name}', nip='{company.Nip}', address='{company.Address}' " +
                    $"WHERE id={CompanyID}";
                MySqlCommand command = new MySqlCommand(EDIT_COMPANY, connection);
                connection.Open();
                var returnedVal = command.ExecuteNonQuery();
                if (returnedVal == 1) state = true;
                connection.Close();
            }
            return state;
        }

        public static bool DeleteCompanyFromDB(Company company, sbyte CompanyID)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string DELETE_COMPANY = $"DELETE FROM companies WHERE nip={company.Nip}";
                MySqlCommand command = new MySqlCommand(DELETE_COMPANY, connection);
                connection.Open();
                var returnedVal = command.ExecuteNonQuery();
                if (returnedVal == 1) state = true;
                connection.Close();
            }
            return state;
        }
        #endregion
    }
}

