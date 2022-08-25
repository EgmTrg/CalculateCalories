using CalculateCalories.ORM;
using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class App : Form
    {
        public DataSet database { get; set; }

        public App() {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e) {
            refresh_Button.PerformClick();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void openDetailedTable_ToolStripMenuItem_Click(object sender, EventArgs e) {
            DetailedForm detailedForm = new DetailedForm();
            detailedForm.Show();
            detailedForm.BringToFront();
        }

        private void refresh_Button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.Select_PivotCalories().Tables[0];
        }
    }
}
