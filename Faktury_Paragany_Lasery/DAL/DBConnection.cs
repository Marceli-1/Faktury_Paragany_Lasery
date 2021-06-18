using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Faktury_Paragany_Lasery.DAL
{
    class DBConnection
    {
        private MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();

        private static DBConnection instance = null;
        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnection();
                return instance;
            }
        }


        public MySqlConnection Connection => new MySqlConnection(stringBuilder.ToString());

        private DBConnection()
        {
            stringBuilder.UserID = Properties.Settings.Default.username;
            stringBuilder.Password = Properties.Settings.Default.password;
            stringBuilder.Database = Properties.Settings.Default.db;
            stringBuilder.Server = Properties.Settings.Default.host;
            stringBuilder.Port = Properties.Settings.Default.port;

        }

    }
}
