using System;
using System.Data;
using System.Data.SqlClient;

namespace CountiesDB
{
    static class DataBaseHelper
    {
        public static string Server { set; get; } = @"PAVEL\SQLEXPRESS";

        public static string DataBase { set; get; } = "Countries_reliz";

        private static string TypeSecurity { get; set; } = "True";

        private static string UserId { get; set; }
        private static string Password { get; set; }

        private static string City { set; get; } = "Cityes";

        private static string Region { set; get; } = "Regions";

        private static string Country { set; get; } = "Countries";

        private static string connectionString = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}", Server, DataBase, TypeSecurity);

        public static void UpdateConnectionString(string server, string dataBase, string typeSecurity)
        {
            Server = server;
            DataBase = dataBase;
            TypeSecurity = typeSecurity;
            connectionString = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}", Server, DataBase, TypeSecurity);
        }
        public static void UpdateConnectionString(string server, string dataBase, string typeSecurity, string userId, string password)
        {
            Server = server;
            DataBase = dataBase;
            TypeSecurity = typeSecurity;
            UserId = userId;
            Password = password;
            connectionString = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2};User Id={3};Password={4}", Server, DataBase, TypeSecurity, UserId, Password);
        }

        public static bool TryConnect()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static DataSet GetAllCountries()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = String.Format("SELECT cs.name as Название," + " cs.code as Код_страны, c.name as Столица," + " cs.area as Площадь, cs.population as Население," + " r.name as Регион" + " FROM {0} as cs inner join {1} as c on cs.city_id = c.id" + " inner join {2} as r on cs.region_id = r.id", Country, City, Region);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch
            {
                return ds;
            }
        }


        public static DataSet GetOneCountry(string countryName)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = String.Format("SELECT cs.name as Название," + " cs.code as Код_страны, c.name as Столица," + " cs.area as Площадь, cs.population as Население," + " r.name as Регион" + " FROM {0} as cs inner join {1} as c on cs.city_id = c.id" + " inner join {2} as r on cs.region_id = r.id " + "where cs.name = '{3}'", Country, City, Region, countryName);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch
            {
                return ds;
            }
        }


        public static int AddOrUpdateValue(string name, string code, string city, double? area, int? population, string region)
        {

            area = area.HasValue ? area : 0.0;
            population = population.HasValue ? population : 0;
            int changeRow = 0;
            try
            {
                int cityId = GetCityId(city);
                int regionId = GetRegionId(region);
                changeRow = AddOrUpdateCountry(name, cityId, area, population, regionId, code);
                return changeRow;
            }
            catch
            {
                return changeRow;
            }
        }

        public static int AddOrUpdateCountry(string name, int cityId, double? area, int? population, int regionId, string code)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Проверяем страну по её коду
                string sql = string.Format("select count(*) from {0} where code = '{1}'", Country, code);
                SqlCommand command = new SqlCommand(sql, connection);
                int count = (int)command.ExecuteScalar();
                int changeRow;
                // Если страна есть в таблице, то редактируем её значения
                if (count != 0)
                {
                    sql = string.Format("update {0} set name = '{1}'," +
                        " city_id = {2}, area = {3}," +
                        " population = {4}, region_id = {5} where code = {6}",
                        Country, name, cityId, area, population, regionId, code);
                    command = new SqlCommand(sql, connection);
                    changeRow = command.ExecuteNonQuery();
                }
                else
                {
                    sql = string.Format("insert into {0} values('{1}', '{2}', {3}, {4}, {5}, {6})",
                        Country, name, code, cityId, area, population, regionId);
                    command = new SqlCommand(sql, connection);
                    changeRow = command.ExecuteNonQuery();
                }
                return changeRow;
            }
        }
        public static int GetCityId(string city)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = string.Format("select count(*) from {0} where name = '{1}'", City, city);
                SqlCommand command = new SqlCommand(sql, connection);
                int count = (int)command.ExecuteScalar();
                int cityId;
                if (count != 0)
                {
                    cityId = FindCityId(city);
                }
                else
                {
                    sql = string.Format("insert into {0} values('{1}')", City, city);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    cityId = FindCityId(city);
                }
                return cityId;
            }
        }
        private static int FindCityId(string city)
        {
            int cityId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = string.Format("select id from {0} where name = '{1}'", City, city);
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cityId = reader.GetInt32(0);
                        }
                    }
                }
            }
            return cityId;
        }

        private static int GetRegionId(string region)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = string.Format("select count(*) from {0} where name = '{1}'", Region, region);
                SqlCommand command = new SqlCommand(sql, connection);
                int count = (int)command.ExecuteScalar();
                int regionId;
                if (count != 0)
                {
                    regionId = FindRegionId(region);
                }
                else
                {
                    sql = string.Format("insert into {0} values('{1}')", Region, region);
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    regionId = FindRegionId(region);
                }
                return regionId;
            }
        }

        private static int FindRegionId(string region)
        {
            int regionId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = string.Format("select id from {0} where name = '{1}'", Region, region);
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            regionId = reader.GetInt32(0);
                        }
                    }
                }
            }
            return regionId;
        }
    }
}