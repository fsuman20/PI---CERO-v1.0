using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI___CERO_v1._0.Models;
using DBLayer;
using System.Data.SqlClient;

namespace PI___CERO_v1._0.Repositories
{
    internal class FinanceSourceRepository
    {
        public static FinanceSource GetFinance(int id)
        {
            string sql = $"SELECT * FROM Finance WHERE Id = {id}";
            return FetchFinance(sql);
        }


        private static FinanceSource FetchFinance(string sql)
        {
            FinanceSource finance = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows == true)
            {
                reader.Read();
                finance = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return finance;
        }

        public static List<FinanceSource> GetFinanceList()
        {
            List<FinanceSource> financex = new List<FinanceSource>();



            string sql = "SELECT * FROM Finance";

            DB.SetConfiguration("fsuman20_DB", "fsuman20", "y;9]1S%b");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                FinanceSource finance = CreateObject(reader);
                financex.Add(finance);
            }
            reader.Close();
            DB.CloseConnection();

            return financex;
        }

        public static int GetSourceId(string financename)
        {
            int id = 0;
            string sql = $"SELECT Id FROM Finance WHERE Id = {financename}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows == true)
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
            string sql = $"SELECT Project_finance FROM Equipment WHERE  Id='{Id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                id = int.Parse(reader["Project_finance"].ToString());
                reader.Close();
            }

            DB.CloseConnection();
            return id;
        }

        private static FinanceSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["FinanceName"].ToString();
            var finance = new FinanceSource
            {
                Id = id,
                FinanceName = name,
            };
            return finance;
        }

    }
}


