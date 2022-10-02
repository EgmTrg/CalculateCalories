using CalculateCalories.ORM;
using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class App : Form
    {
        public App() {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            InitializeComponent();
        }

        #region Events

        private void App_Load(object sender, EventArgs e) {
            refresh_Button.PerformClick();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void refresh_Button_Click(object sender, EventArgs e) {
            DateTime begin_date = dateTimePicker1.Value, end_date = dateTimePicker2.Value;
            table.DataSource = ORMBase.Instance.GetTable(ORMBase.DBTable.Pivot, begin_date, end_date).Data.Tables[0];
        }
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DetailedForm detailedForm = new DetailedForm(
                new Tools.RowInfo {
                    PivotID = (int)table.Rows[e.RowIndex].Cells[0].Value,
                    Date = (DateTime)table.Rows[e.RowIndex].Cells[1].Value
                }
            );

            detailedForm.BringToFront();
            detailedForm.Show();
        }

        private void newData_button_Click(object sender, EventArgs e) {
            ORMBase.Instance.Insert_Pivot();
            refresh_Button.PerformClick();
        }
    }
}
