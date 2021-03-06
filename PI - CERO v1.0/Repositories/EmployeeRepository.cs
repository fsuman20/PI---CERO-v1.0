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
            string sql = $"SELECT * FROM CIP_Employee WHERE Id = {id}";
            return FetchEmployee(sql);
        }


        private static Employee FetchEmployee(string sql)
        {
            Employee employee = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows == true)
            {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return employee;
        }


        public static List<Employee> GetCipEmployees()
        {
            List<Employee> employeex = new List<Employee>();



            string sql = "SELECT * FROM CIP_Employee";

            DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Employee employee = CreateObject(reader);
                employeex.Add(employee);
            }

            reader.Close();
            DB.CloseConnection();

            return employeex;
        }

        public static int GetEmployeeId(string name)
        {
            int id = 0;
            var wrd = name.Split(' ');
            string sql = $"SELECT Id FROM Employee WHERE  FirstName=N'{wrd[0]}' AND Surname=N'{wrd[1]}';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                id = int.Parse(reader["Id"].ToString());
                reader.Close();
            }

            DB.CloseConnection();
            return id;
        }

        public static int GetCurrentId(string Id)
        {
            int id = 0;

            string sql = $"SELECT Employee FROM Equipment WHERE  Id='{Id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                id = int.Parse(reader["Employee"].ToString());
                reader.Close();
            }

            DB.CloseConnection();
            return id;
        }

private static Employee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["FirstName"].ToString();
            string surname = reader["Surname"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var employee = new Employee { OIB = id, FirstName = name, Surname = surname, Username = username, Password = password };
            return employee;
        }
    }
}
