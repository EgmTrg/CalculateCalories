using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CalculateCalories.ORM
{
    public class ORMBase
    {
        private static ORMBase instance;
        public static ORMBase Instance
        {
            get {
                if (instance == null)
                    instance = new ORMBase();
                return instance;
            }
        }
        public struct DMLDatas
        {
            //public OperationType opType;
            public int ID;
            public int PivotID;
            public string Date;
            public string ProductName;
            public int Portion;
            public int Amount;
            public double Calorie;
            public double Protein;
            public double Carbohydrate;
            public double Fat;
            public double Fiber;
            public double Cholesterol;
            public double Sodium;
            public double Potassium;
        }

        public enum DBTable { Pivot, Detailed }
        public DBTable Table { get; set; }

        public DataSet GetTable(DBTable table, DateTime? begin = null, DateTime? end = null) {
            string query = $"SELECT * FROM [{table}]";
            if (table == DBTable.Pivot && begin.HasValue && end.HasValue)
                query += $" WHERE Date BETWEEN {begin.Value.ToSqlDate()} AND {end.Value.ToSqlDate()}";
            query += " ORDER BY [Date]";

            SqlCommand cmd = new SqlCommand(query, ORMTools.Connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt);
            return dt;
        }

        public DataSet GetTable(int PivotID) {
            string query = $"SELECT * FROM [Detailed] WHERE PivotID = {PivotID}";

            SqlCommand cmd = new SqlCommand(query,ORMTools.Connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt);
            return dt;
        }
        #region DMLOperations

        #region ForDetailedTable

        public bool Insert_Detailed(DMLDatas datas) {
            string query_Columns = "(";
            string query_Values = " Values(";
            SqlCommand cmd = new SqlCommand("INSERT INTO [Detailed]", ORMTools.Connection);

            foreach (var item in typeof(DMLDatas).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)) {
                query_Columns += item.Name + ",";
                query_Values += item.GetValue(datas).ToString().Replace(',', '.') + ",";
            }

            // En sonda kalan virgülü silmek için Remove yapıyoruz.
            query_Columns = query_Columns.Remove(query_Columns.Length - 1) + ")";
            query_Values = query_Values.Remove(query_Values.Length - 1) + ")";

            cmd.CommandText += query_Columns + query_Values;

            ORMTools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            ORMTools.Connection.Close();
            return result;
        }

        public bool Insert_Pivot() {
            string query_Insert = "INSERT INTO [Pivot] (ID,Date,Explanation,[Total Calories]) ";
            string query_Values = $"VALUES({Tools.RandomID()},{DateTime.Now.ToSqlDate()},0,0)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query_Insert + query_Values;
            cmd.Connection = ORMTools.Connection;

            ORMTools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            ORMTools.Connection.Close();
            return result;
        }

        public bool Update_Detailed() {
            return false;
        }

        public bool Delete_DetailedTable(int ID) {
            string query = $"Delete from [Detailed] where ID = " + ID.ToString();
            SqlCommand cmd = new SqlCommand(query, ORMTools.Connection);

            ORMTools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            ORMTools.Connection.Close();
            return result;
        }
        #endregion
        #endregion
    }
}