using MySql.Data.MySqlClient;
using System.Configuration;

namespace ÇiçekçiApp
{
    public static class VeritabaniBaglantisi
    {
        private static readonly string connectionString;

        static VeritabaniBaglantisi()
        {
            connectionString = "server=127.0.0.1;port=3306;database=CicekciDB;user=root;password=Yavuz2002;";
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
} 