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
        /*  ------------------------------------------------------------------------------
         *                              PROPERTY REGION
         *  ------------------------------------------------------------------------------ */

        public int GetSelectedRowInDataGridView() => dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

        #endregion

        #region Events
        /*  ------------------------------------------------------------------------------
         *                              EVENTS REGION
         *  ------------------------------------------------------------------------------ */

        private void DetailedForm_Load(object sender, EventArgs e) {
            refresh_button.PerformClick();
        }

        private void insert_button_Click(object sender, EventArgs e) {
            ORMBase.DMLDatas datas = ORMBase.Instance.GenerateRandomProductItem();
            bool result = ORMBase.Instance.Insert_DetailedCalories(datas);

            MessageBox.Show($"Insert işlemi {result}");
        }

        private void delete_button_Click(object sender, EventArgs e) {
            DeleteSelectedRow_Single();
        }

        private void refresh_button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.Select_DetailedCalories().Tables[0];
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            OpenContextMenuStripItem(e);
        }


        private void delete_ToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteSelectedRow_Single();
        }

        private void open_ToolStripMenuItem_Click(object sender, EventArgs e) {
            string info = GetInfoSelectedRow();
            MessageBox.Show(info, "Satır Bilgilendirmesi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Custom Methods
        /*  ------------------------------------------------------------------------------
         *                              CUSTOM METHODS REGION
         *  ------------------------------------------------------------------------------ */

        private void OpenContextMenuStripItem(MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell) {
                SelectRowWhenClicked(e);
            }
        }

        private void SelectRowWhenClicked(MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = dataGridView1.HitTest(e.X, e.Y);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[hit.RowIndex].Selected = true;
        }

        private void DeleteSelectedRow_Single() {
            int selectedRow = GetSelectedRowInDataGridView();
            if (selectedRow == -1) {
                MessageBox.Show("Veri silmek için satır seçmeniz gerekmektedir.", "Satır Seç", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            int selectedRowID = (int) dataGridView1.Rows[selectedRow].Cells["ID"].Value;
            bool result = ORMBase.Instance.Delete_DetailedCalories(selectedRowID);
            dataGridView1.Rows.RemoveAt(selectedRow);
            dataGridView1.ClearSelection();
            MessageBox.Show($"Silme islemi {result}");
        }

        private string GetInfoSelectedRow() {
            int selectedRow = GetSelectedRowInDataGridView();
            string info = "";

            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                info += dataGridView1.Columns[i].Name + ": " + dataGridView1.Rows[selectedRow].Cells[i].Value.ToString() + '\n';
            return info;
        }
        #endregion

        private void getSelectedRowIndex_button_Click(object sender, EventArgs e) {
            MessageBox.Show(GetSelectedRowInDataGridView().ToString());
        }
    }
}
