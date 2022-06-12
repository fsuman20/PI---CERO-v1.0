using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI___CERO_v1._0.Models;
using System.Data.SqlClient;
using PI___CERO_v1._0.fsuman20_DBDataSetTableAdapters;
using DBLayer;

namespace PI___CERO_v1._0.Repositories
{
    public class EquipmentRepository
    {
        public static Equipment GetEquipment(int id)
        {
            Equipment equipment = null;

            string sql = $"SELECT * FROM Equipment WHERE Id = {id}"; ;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                equipment = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return equipment;
        }
        public static List<Equipment> GetEquimpent()
        {
            List<Equipment> equipmentx = new List<Equipment>();
            
            string sql = "SELECT * FROM Equipment";
            DB.SetConfiguration("ahamzic20_DB", "ahamzic20", "pNzDysZy");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Equipment equipment = CreateObject(reader);
                equipmentx.Add(equipment);
            }
            reader.Close();
            DB.CloseConnection();
            return equipmentx;
        }
        private static Equipment CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["EquipmentName"].ToString();
            string description = reader["Description"].ToString();
         //   DateTime arrival = DateTime.Parse(reader["Arrival"].ToString());
            int finance = int.Parse(reader["idSource"].ToString());
            string project = reader["ProjectName"].ToString();
          //  string reason = reader["Reason"].ToString();
            //DateTime expected = DateTime.Parse(reader["DateTime"].ToString());
            int appuser = int.Parse(reader["IdEmployee"].ToString());
            int employee = int.Parse(reader["IdSupplier"].ToString());
            var equipment = new Equipment { Id = id, EquipmentName = name, Description = description,
                //Arrival = arrival, 
                Project_finance = finance, Project = project, 
                //Reason = reason, 
              //  Expected = expected, 
                App_User = appuser, Employee = employee };
            return equipment;
        }




        public static void InsertEquipment(string name, int description, int finance, string project, int employee, int appuser)
        {
            string sql = $"INSERT INTO Equipment (EquipmentName, Description, Project, Project_finance, Employee, App_User, Arrival) VALUES ('{name}','{description}','{project}',{finance},{employee},{appuser}, GETDATE())";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateEquipment(string id, string name, int description, int finance, string project, int employee, int appuser)
        {
            string sql = $"UPDATE Equipment SET Arrival = GETDATE(), EquipmentName='{name}', Description='{description}', Project='{project}', Project_finance={finance}, Employee={employee}, App_User={appuser}, WHERE Id={id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DeleteEquipment(string id)
        {
            string sql = $"DELETE FROM Equipment WHERE Id={id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
