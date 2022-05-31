using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using PI___CERO_v1._0.Models;
using System.Data.SqlClient;

namespace PI___CERO_v1._0.Repositories
{
    public class EmployeeRepository
    {
        public static Employee GetEmployee(int id)
        {
            string sql = $"SELECT * FROM CIP_zaposlenik WHERE Id_cip = {id}";
            return FetchEmployee(sql);
        }

        private static Employee FetchEmployee(string sql)
        {
            DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Employee employee = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return employee;
        }

        private static Employee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_cip"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string username = reader["Username"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            var employee = new Employee { OIB = id, Ime = ime, Prezime = prezime, Username = username, Lozinka = lozinka };
            return employee;
        }
    }
}
