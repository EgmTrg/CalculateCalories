using CalculateCalories.ORM;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            ORMBase.DMLDatas datas = new ORMBase.DMLDatas();
            if (AutoProduct_checkBox.Checked) {
                datas = ORMBase.Instance.GenerateRandomProductItem();
            }
            else {
                datas.ID = (int)ID_numericUpDown.Value;
                datas.Date = "\'" + dateTimePicker.Value.ToString().Remove(10).Replace('.', '/') + "\'";
                datas.ProductName = $"\'{pName_textBox.Text}\'";
                datas.Portion = (int)portion_numericUpDown.Value;
                datas.Amount = (int)amount_numericUpDown.Value;
                datas.Calorie = double.Parse(calorie_textBox.Text);
                datas.Protein = double.Parse(calorie_textBox.Text);
                datas.Carbohydrate = double.Parse(calorie_textBox.Text);
                datas.Fat = double.Parse(fat_textBox.Text);
                datas.Fiber = double.Parse(fiber_textBox.Text);
                datas.Cholesterol = double.Parse(cholesterol_textBox.Text);
                datas.Potassium = double.Parse(potassium_textBox.Text);
                datas.Sodium = double.Parse(sodium_textBox.Text);
            }

            bool result = ORMBase.Instance.Insert_DetailedCalories(datas);
            if (refresh_checkBox.Checked)
                refresh_button.PerformClick();
            //MessageBox.Show($"Insert işlemi {result}");
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

            int selectedRowID = (int)dataGridView1.Rows[selectedRow].Cells["ID"].Value;
            bool result = ORMBase.Instance.Delete_DetailedCalories(selectedRowID);
            dataGridView1.Rows.RemoveAt(selectedRow);
            dataGridView1.ClearSelection();

            if (refresh_checkBox.Checked)
                refresh_button.PerformClick();
            //MessageBox.Show($"Silme islemi {result}");
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
