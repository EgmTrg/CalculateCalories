using CalculateCalories.ORM;
using System;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class App : Form
    {
        public App() {
            InitializeComponent();
        }

        #region Events

        private void App_Load(object sender, EventArgs e) {
            refresh_Button.PerformClick();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void openDetailedTable_ToolStripMenuItem_Click(object sender, EventArgs e) {
            DetailedForm detailedForm = new DetailedForm();
            detailedForm.Show();
        }

        private void refresh_Button_Click(object sender, EventArgs e) {
            DateTime begin_date = dateTimePicker1.Value, end_date = dateTimePicker2.Value;
            dataGridView1.DataSource = ORMBase.Instance.GetPivotTable(begin_date, end_date).Tables[0];
        }
        #endregion
    }
}
