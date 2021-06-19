using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Faktury_Paragany_Lasery.DAL.Repositories
{
    class RepositoryBackBone<T> where T: class, new()
    {
        public static List<T> GetAllRecords(string query, Func<MySqlDataReader, T> instatiator)
        {
            List<T> companies = new List<T>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    companies.Add(instatiator(reader));
                connection.Close();
            }
            Console.WriteLine("LUL TO DZIALA");
            return companies;

        }
    }
}
