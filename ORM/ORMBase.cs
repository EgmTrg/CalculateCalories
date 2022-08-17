using System;
using System.Data;
using System.Data.SqlClient;

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
                return null;
            }
        }

        public enum OperationType { SELECT, INSERT, UPDATE, DELETE }

        public struct DMLDatas
        {
            public OperationType opType;
            public int ID;
            public DateTime date;
            public string pName;
            public int portion;
            public int amount;
            public double calorie;
            public double protein;
            public double carbohydrate;
            public double fat;
            public double fiber;
            public double cholesterol;
            public double sodium;
            public double potassium;
        }

        public SqlDataAdapter GetPivotTable() {
            SqlCommand cmd = new SqlCommand("GetPivotTable");
            cmd.Connection = Tools.Connection;
            return new SqlDataAdapter(cmd);
        }

        public DataSet DMLOperations(DMLDatas dmldatas) {
            SqlCommand sqlComm = new SqlCommand("DMLOperations", Tools.Connection);
            DataSet dataSet = new DataSet();

            sqlComm.Parameters.AddWithValue("@OPERATION", dmldatas.opType.ToString());
            sqlComm.Parameters.AddWithValue("@ID", dmldatas.ID);
            sqlComm.Parameters.AddWithValue("@date", dmldatas.date);
            sqlComm.Parameters.AddWithValue("@pName", dmldatas.pName);
            sqlComm.Parameters.AddWithValue("@portion", dmldatas.portion);
            sqlComm.Parameters.AddWithValue("@amount", dmldatas.amount);
            sqlComm.Parameters.AddWithValue("@calorie", dmldatas.calorie);
            sqlComm.Parameters.AddWithValue("@protein", dmldatas.protein);
            sqlComm.Parameters.AddWithValue("@carbohydrate", dmldatas.carbohydrate);
            sqlComm.Parameters.AddWithValue("@fat", dmldatas.fat);
            sqlComm.Parameters.AddWithValue("@fiber", dmldatas.fiber);
            sqlComm.Parameters.AddWithValue("@cholesterol", dmldatas.cholesterol);
            sqlComm.Parameters.AddWithValue("@sodium", dmldatas.sodium);
            sqlComm.Parameters.AddWithValue("@potassium", dmldatas.potassium);

            sqlComm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlComm;
            adapter.Fill(dataSet);

            return dataSet;
        }

        
    }
}
