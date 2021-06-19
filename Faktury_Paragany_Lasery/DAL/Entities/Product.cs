using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace Faktury_Paragany_Lasery.DAL.Entities
{
    class Product
    {
        #region Properties

        public string Name { get; set; }
        public sbyte Id { get; set; }
        public float Price { get; set; }

        #endregion

        #region Constructors
        public Product(string name, string price)
        {

        }
        public Product(Product company)
        {
        }

        public Product(MySqlDataReader reader)
        {
        }
        #endregion


        #region Methods
        public string ToInsert() => $"()";

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
