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
    public class EquipmentRepository
    {
        public static Equipment GetEquipment(int id)
        {
            Equipment equipment = null;

            string sql = $"SELECT * FROM Oprema WHERE ID = {id}";
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
            var equipment = new List<Equipment>();

            string sql = "SELECT * FROM Oprema";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Equipment equipmentx = CreateObject(reader);
                equipment.Add(equipmentx);
            }
            reader.Close();
            DB.CloseConnection();
            return equipment;
        }
        private static Equipment CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string name = reader["Naziv"].ToString();
            string description = reader["Opis"].ToString();
            DateTime arrival = DateTime.Parse(reader["Dospijece"].ToString());
            string finance = reader["Financiranje"].ToString();
            string project = reader["Projekt"].ToString();
            string reason = reader["Razlog"].ToString();
            DateTime expected = DateTime.Parse(reader["Povratak"].ToString());
            User user = (User)reader["Korisnik"].ToString();
            Employee employee = (Employee)reader["Zaposlenik"].ToString();
            var equipment = new Equipment { Id = id, EquipmentName = name, Description = description, Arrival = arrival, Finance = finance, Project = project, Reason = reason, Expected = expected, User = user, CIPEmployee = employee };
            return equipment;
        }
    }
}
