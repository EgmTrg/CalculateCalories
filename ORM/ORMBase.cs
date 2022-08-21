using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

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
        public enum OperationType { SELECT, INSERT, UPDATE, DELETE }

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

        public DataSet GetPivotTable() {
            return null;
        }

        public DataSet GetDetailedTable() {
            return null;
        }

        #region DMLOperations
        public DataSet Select_DetailedCalories() {
            SqlCommand cmd = new SqlCommand("Select * from DetailedCalories ORDER BY Date", Tools.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dataSet);
            return dataSet;
        }

        public bool Insert_DetailedCalories(DMLDatas datas) {
            string query_Columns = "(";
            string query_Values = " Values(";
            SqlCommand cmd = new SqlCommand("Insert Into DetailedCalories", Tools.Connection);

            foreach (var item in typeof(DMLDatas).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)) {
                query_Columns += item.Name + ",";
                query_Values += item.GetValue(datas).ToString().Replace(',', '.') + ",";
            }

            // En sonda kalan virgülü silmek için Remove yapıyoruz.
            query_Columns = query_Columns.Remove(query_Columns.Length - 1) + ")";
            query_Values = query_Values.Remove(query_Values.Length - 1) + ")";

            cmd.CommandText += query_Columns + query_Values;
            //System.Windows.Forms.MessageBox.Show(cmd.CommandText);

            Tools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            Tools.Connection.Close();
            return result;
        }

        public bool Update_DetailedCalories() { return false; }

        public bool Delete_DetailedCalories(int ID) {
            string query = "Delete from DetailedCalories where ID = " + ID.ToString();
            SqlCommand cmd = new SqlCommand(query, Tools.Connection);
            
            Tools.Connection.Open();
            bool result = cmd.ExecuteNonQuery() >= 1 ? true : false;
            Tools.Connection.Close();
            return result;
        }
        #endregion

        #region TEMP
        public DMLDatas GenerateRandomProductItem() {
            Random rand = new Random();
            DMLDatas data = new DMLDatas();

            data.ID = rand.Next(9000, 10000);
            data.Date = "\'" + DateTime.Now.ToString().Remove(10).Replace('.', '/') + "\'";
            data.ProductName = "\'TEST URUN\'";
            data.Portion = rand.Next(1, 3);
            data.Amount = rand.Next(1, 3);
            data.Calorie = Math.Round(rand.NextDouble() * 100, 2);
            data.Protein = Math.Round(rand.NextDouble() * 100, 2);
            data.Carbohydrate = Math.Round(rand.NextDouble() * 100, 2);
            data.Fat = Math.Round(rand.NextDouble() * 100, 2);
            data.Fiber = Math.Round(rand.NextDouble() * 100, 2);
            data.Cholesterol = Math.Round(rand.NextDouble() * 100, 2);
            data.Sodium = Math.Round(rand.NextDouble() * 100, 2);
            data.Potassium = Math.Round(rand.NextDouble() * 100, 2);

            return data;
        }
        #endregion
    }
}
