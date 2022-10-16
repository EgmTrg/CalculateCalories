using CalculateCalories.ORM;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class App : Form
    {
        private int BiggestPivot_ID = 0;
        private List<int> Marked_Rows { get; set; }

        public App() {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            InitializeComponent();

            Marked_Rows = new List<int>();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 0) {
                return;
            }

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
            DefineBiggestID();
            ORMBase.Instance.Insert_Pivot(BiggestPivot_ID + 1);
            refresh_Button.PerformClick();
            DefineBiggestID();
        }

        private void App_Enter(object sender, EventArgs e) {
            refresh_Button.PerformClick();
        }

        #endregion

        #region Repeated Code Fields
        private void dataGridView1_CheckBoxValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != 0)
                return;

            DataGridViewRow row = table.Rows[e.RowIndex];
            if ((Boolean)row.Cells[0].EditedFormattedValue)
                Marked_Rows.Add((int)row.Cells[1].Value);
            else
                Marked_Rows.Remove((int)row.Cells[1].Value);
        }

        private void DefineBiggestID() {
            if (table.Rows.Count <= 1)
                BiggestPivot_ID = 0;

            for (int i = 0; i < table.Rows.Count - 1; i++) {
                int value = (int)table.Rows[i].Cells[1].Value;
                if (BiggestPivot_ID < value)
                    BiggestPivot_ID = value;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Marked_Rows.Count <= 0) {
                MessageBox.Show("Veri silmek için satır(lar) seçmeniz gerekmektedir.", "Satır Seç", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string result = "";

            DialogResult dialog = MessageBox.Show("Seçili satırlar silinecek ve geri alinamayacak!", "Emin Misin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (dialog == DialogResult.Yes) {
                foreach (int id in Marked_Rows) {
                    result = ORMBase.Instance.Delete_DetailedTable(ORMBase.DBTable.Pivot, ORMBase.TableItem.Row, id).Message;
                }
            }

            MessageBox.Show(result);
            refresh_Button.PerformClick();
        }
        #endregion
    }
}
