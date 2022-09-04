using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

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

        public DataSet GetPivotTable(DateTime begin_date, DateTime end_date) {
            string query = "Select DetailedCalories.Date," +
                            "SUM(Calorie) as \'Total Calorie\'," +
                            "SUM(Protein) as \'Total Protein\'," +
                            "SUM(Fat) as \'Total Fat\'," +
                            "SUM(Portion) as \'Total Portion\'" +
                            "From DetailedCalories " +
                           $"Where date Between {begin_date.ToSqlDate()} and {end_date.ToSqlDate()} " +
                            "Group By [Date]";

            SqlCommand cmd = new SqlCommand(query, ORMTools.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dataSet);
            return dataSet;
        }

        #region DMLOperations

        #region ForDetailedTable
        public DataSet Select_DetailedCalories() {
            SqlCommand cmd = new SqlCommand("Select * from DetailedCalories ORDER BY Date", ORMTools.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dataSet);
            return dataSet;
        }

        public bool Insert_DetailedCalories(DMLDatas datas) {
            string query_Columns = "(";
            string query_Values = " Values(";
            SqlCommand cmd = new SqlCommand("Insert Into DetailedCalories", ORMTools.Connection);

            foreach (var item in typeof(DMLDatas).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)) {
                query_Columns += item.Name + ",";
                query_Values += item.GetValue(datas).ToString().Replace(',', '.') + ",";
            }

            // En sonda kalan virgülü silmek için Remove yapıyoruz.
            query_Columns = query_Columns.Remove(query_Columns.Length - 1) + ")";
            query_Values = query_Values.Remove(query_Values.Length - 1) + ")";

            cmd.CommandText += query_Columns + query_Values;
            //System.Windows.Forms.MessageBox.Show(cmd.CommandText);

            ORMTools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            ORMTools.Connection.Close();
            return result;
        }

        public bool Update_DetailedCalories() { 
            return false; 
        }

        public bool Delete_DetailedCalories(int ID) {
            string query = "Delete from DetailedCalories where ID = " + ID.ToString();
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