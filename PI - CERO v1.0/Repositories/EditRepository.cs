/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;
using PI___CERO_v1._0.Models;

namespace PI___CERO_v1._0.Repositories
{
    public class EditRepository
    {
        public static Equipment GetEquipments(Equipment equipment)
        {
            Equipment equipmentx = null;
            string sql = $"SELECT * FROM Oprema WHERE Id = {equipment.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                equipmentx = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return equipmentx;
        }

        public static List<Equipment> GetEquipment(Equipment equipment)
        {
            List<Equipment> equipmentx = new List<Equipment>();

            string sql = $"SELECT * FROM Oprema WHERE Id = {equipment.Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Equipment equipmentx = CreateObject(reader);
                equipment.Add(equipmentx);
            }

            reader.Close();
            DB.CloseConnection();

            return equipmentx;
        }

        private static Equipment CreateObject(SqlDataReader reader)
        {
            int idActivities = int.Parse(reader["Id"].ToString());
            var equipment = EquipmentRepository.GetEquipment(Id);


            var equipment1 = new Equipment
            var equipment = new Equipment { Id = id, EquipmentName = name, Description = description, Arrival = arrival, Finance = finance, Project = project, Reason = reason, Expected = expected, User = user, CIPEmployee = employee };

            return evaluation;
        }

        public static void InsertEvaluation(Equipment equipment)
        {
            string sql = $"INSERT INTO oprema (Id) VALUES ({equipment.Id})";
            DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateEvaluation(Evaluation evaluation, Teacher teacher, int points)
        {
            string sql = $"UPDATE Evaluations SET IdTeachers = {teacher.Id},  Points = {points}, EvaluationDate = GETDATE() WHERE IdActivities = {evaluation.Activity.Id} AND IdStudents = {evaluation.Student.Id}";
                        DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
}*/
