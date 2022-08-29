using System;
using System.Windows.Forms;

namespace CalculateCalories
{
    public static class Tools
    {
        public static int GetSelectedRowInDataGridView(DataGridView dataGridView) => 
            dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

        public static string DateToString(DateTime dateTime) => 
            dateTime.ToString().Remove(11).Replace('.', '/');


        public static DateTime StringToDateTime(string date) {
            string[] splitted_date = date.Split('/');
            int day = int.Parse(splitted_date[0]);
            int mounth = int.Parse(splitted_date[1]);
            int year = int.Parse(splitted_date[2]);
            return new DateTime(year, mounth, day);
        }
    }
}
