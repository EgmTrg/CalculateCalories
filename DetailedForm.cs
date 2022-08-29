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
        }

        private void delete_button_Click(object sender, EventArgs e) {
            DeleteSelectedRow_Single();
        }

        private void refresh_button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.Select_DetailedCalories().Tables[0];
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell) {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void delete_ToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteSelectedRow_Single();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.DataBoundItem == null)
                return;

            ID_numericUpDown.Value = (int)row.Cells[0].Value;
            dateTimePicker.Value = Tools.StringToDateTime(row.Cells[1].Value.ToString());
            pName_textBox.Text = row.Cells[2].Value.ToString();
            portion_numericUpDown.Value = int.Parse(row.Cells[3].Value.ToString());
            amount_numericUpDown.Value = int.Parse(row.Cells[4].Value.ToString());
            calorie_textBox.Text = row.Cells[5].Value.ToString();
            protein_textBox.Text = row.Cells[6].Value.ToString();
            carbohydrate_textBox.Text = row.Cells[7].Value.ToString();
            fat_textBox.Text = row.Cells[8].Value.ToString();
            fiber_textBox.Text = row.Cells[9].Value.ToString();
            cholesterol_textBox.Text = row.Cells[10].Value.ToString();
            sodium_textBox.Text = row.Cells[11].Value.ToString();
            potassium_textBox.Text = row.Cells[12].Value.ToString();
        }
        #endregion

        #region Custom Methods
        /*  ------------------------------------------------------------------------------
         *                              CUSTOM METHODS REGION
         *  ------------------------------------------------------------------------------ */

        private void DeleteSelectedRow_Single() {
            int selectedRow = Tools.GetSelectedRowInDataGridView(dataGridView1);
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
        }

        private string GetInfoSelectedRow() {
            int selectedRow = Tools.GetSelectedRowInDataGridView(dataGridView1);
            string info = "";

            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                info += dataGridView1.Columns[i].Name + ": " + dataGridView1.Rows[selectedRow].Cells[i].Value.ToString() + '\n';
            return info;
        }
        #endregion

        #region TEMP

        private void open_ToolStripMenuItem_Click(object sender, EventArgs e) {
            string info = GetInfoSelectedRow();
            MessageBox.Show(info, "Satır Bilgilendirmesi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seciliSatirNumarasiToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(Tools.GetSelectedRowInDataGridView(dataGridView1).ToString());
        }

        #endregion
    }
}
