using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI___CERO_v1._0.Models;
using System.Data.SqlClient;
using DBLayer;

namespace PI___CERO_v1._0.Repositories
{
    internal class EquipmentDataListRepository
    {
        public static EquipmentDataList GetDataEquipment(int id)
        {
            EquipmentDataList data = null;

            string sql = $"SELECT * FROM Equipment WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows == true)
            {
                reader.Read();
                data = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return data;
        }
        public static List<EquipmentDataList> GetDataEquimpentx()
        {
            List<EquipmentDataList> datax = new List<EquipmentDataList>();
            DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");
            string sql = $"SELECT e.ID, e.EquipmentName, e.Project, e.Description, (c.FirstName + ' ' + c.Surname) AS CIPEmployee, e.Arrival, s.FinanceName AS Finance,(f.FirstName + ' ' + f.Surname) AS App_User FROM Equipment e JOIN Employee c ON e.Employee = c.Id JOIN Finance s ON e.Finance = et.Id JOIN User f ON e.App_User= f.Id";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                EquipmentDataList data = CreateObject(reader);
                datax.Add(data);
            }
            reader.Close();
            DB.CloseConnection();
            return datax;
        }
        private static EquipmentDataList CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["EquipmentName"].ToString();
            string description = reader["Description"].ToString();
            DateTime arrival = DateTime.Parse(reader["Arrival"].ToString());
            string finance = reader["Project_finance"].ToString();
            string project = reader["Project"].ToString();
            string appuser = reader["App_User"].ToString();
            string employee = reader["Employee"].ToString();
            var data = new EquipmentDataList { Id = id, Name = name, Description = description, Arrival = arrival, Finance = finance, Project = project, AppUser = appuser, CIPEmployee = employee };
            return data;
        }
    }
}
