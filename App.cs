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
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
