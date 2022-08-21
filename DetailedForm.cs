using CalculateCalories.ORM;
using System;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class DetailedForm : Form
    {
        public DetailedForm() {
            InitializeComponent();
        }

        #region Properties
        public int GetSelectedRowInDataGridView() => dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
        #endregion

        #region Events
        private void DetailedForm_Load(object sender, System.EventArgs e) {
            refresh_button.PerformClick();
        }

        private void insert_button_Click(object sender, System.EventArgs e) {
            ORMBase.DMLDatas datas = ORMBase.Instance.GenerateRandomProductItem();
            bool result = ORMBase.Instance.Insert_DetailedCalories(datas);

            MessageBox.Show($"Insert işlemi {result}");
        }

        private void refresh_button_Click(object sender, System.EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.Select_DetailedCalories().Tables[0];
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            OpenContextMenuStripItem(e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteSelectedRow_Single(e);
        }
        #endregion

        #region Custom Methods
        private void OpenContextMenuStripItem(MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell) {
                SelectRowWhenClicked(e);
                if ((hit.ColumnIndex == dataGridView1.Columns.Count - 1) && (hit.Type == DataGridViewHitTestType.ColumnHeader))
                dataGirdView_contextMenuStrip.Show();
            }
        }

        private void SelectRowWhenClicked(MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = dataGridView1.HitTest(e.X, e.Y);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[hit.RowIndex].Selected = true;
        }

        private void DeleteSelectedRow_Single(EventArgs e) {
            int selectedRow = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            dataGridView1.Rows.RemoveAt(selectedRow);
            dataGridView1.ClearSelection();
        }
        #endregion

        private void getInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            int selectedRow = GetSelectedRowInDataGridView();
            string values = "";

            for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                values += dataGridView1.Columns[i].Name + ": " + dataGridView1.Rows[selectedRow].Cells[i].Value.ToString() + '\n';
            }

            MessageBox.Show(values);
        }
    }
}
