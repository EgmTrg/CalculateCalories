using System;
using System.Windows.Forms;

namespace CalculateCalories
{
    public static class Tools
    {
        public static int RandomID() => new Random().Next(9000, 10000);

        public static int GetSelectedRowInDataGridView(DataGridView dataGridView) => 
            dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

        public static string DateToString(this DateTime dateTime) => 
            dateTime.ToString().Remove(11).Replace('.', '/');

        public static DateTime StringToDateTime(string date) {
            string[] splitted_date = date.Remove(10).Split('.');
            int day = int.Parse(splitted_date[0]);
            int mounth = int.Parse(splitted_date[1]);
            int year = int.Parse(splitted_date[2]);
            return new DateTime(year, mounth, day);
        }

        public static DateTime RandomDate(this Random random) {
            DateTime start_date = new DateTime(2022,1,1);
            int dateTime_Range = (DateTime.Today - start_date).Days;

            return start_date.AddDays(random.Next(dateTime_Range));
        }

    }
}
