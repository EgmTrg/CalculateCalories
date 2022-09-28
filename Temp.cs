using CalculateCalories.ORM;
using System;
using System.Windows.Forms;
using static CalculateCalories.ORM.ORMBase;

namespace CalculateCalories
{
    internal static class Temp
    {
        public static DMLDatas GenerateRandomProductItem(int pivot_ID) {
            Random rand = new Random();
            DMLDatas data = new DMLDatas();

            data.ID = rand.Next(9000, 10000);
            /*data.PivotID = 9999;*/
            data.PivotID = pivot_ID;
            data.Date = rand.RandomDate().ToSqlDate();
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

        public static string GetInfoSelectedRow(DataGridView dataGridView) {
            int selectedRow = Tools.GetSelectedRowInDataGridView(dataGridView);
            string info = "";

            for (int i = 1; i < dataGridView.Columns.Count; i++)
                info += dataGridView.Columns[i].Name + ": " + dataGridView.Rows[selectedRow].Cells[i].Value.ToString() + '\n';
            return info;
        }
    }
}
