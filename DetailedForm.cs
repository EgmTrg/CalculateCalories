﻿using CalculateCalories.ORM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculateCalories
{
    public partial class DetailedForm : Form
    {
        private int ID { get; set; }
        List<int> marked_Rows = new List<int>();

        public DetailedForm(Tools.RowInfo row) {
            InitializeComponent();
            this.ID = row.PivotID;
            Text = row.PivotID.ToString();
            ID_numericUpDown.Value = row.PivotID;
            dateTimePicker.Value = row.Date;
        }

        #region Events
        /*  ------------------------------------------------------------------------------
         *                              EVENTS REGION
         *  ------------------------------------------------------------------------------ */

        private void DetailedForm_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.GetTable(this.ID).Data.Tables[0];
            refresh_button.PerformClick();
        }

        private void refresh_button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = ORMBase.Instance.GetTable(this.ID).Data.Tables[0];
            HideColumns();
        }

        private void insert_button_Click(object sender, EventArgs e) {
            ORMBase.DMLDatas datas = new ORMBase.DMLDatas();
            if (AutoProduct_checkBox.Checked) {
                datas = Temp.GenerateRandomProductItem(this.ID);
            }
            else {
                datas.ID = this.ID;
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

            ORMBase.Instance.Insert_Detailed(datas);
            if (refresh_checkBox.Checked)
                refresh_button.PerformClick();
        }

        private void delete_button_Click(object sender, EventArgs e) {
            if (marked_Rows.Count <= 0) {
                MessageBox.Show("Veri silmek için satır(lar) seçmeniz gerekmektedir.", "Satır Seç", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            DialogResult dialog = MessageBox.Show("Seçili satırlar silinecek ve geri alinamayacak!", "Emin Misin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (dialog == DialogResult.Yes) {
                foreach (int oneSingle_row in marked_Rows) {
                    string message = ORMBase.Instance.Delete_DetailedTable(oneSingle_row).Message;
                }
            }

            if (refresh_checkBox.Checked)
                refresh_button.PerformClick();
        }

        private void deleteTable_button_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bu tablo komple silinecek ve geri alinamayacak!", "Emin Misin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes) {
                string message = ORMBase.Instance.Delete_DetailedTable(this.ID).Message;
                MessageBox.Show(message);
            }
        }


        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell) {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.DataBoundItem == null)
                return;

            ID_numericUpDown.Value = (int)row.Cells[1].Value;
            dateTimePicker.Value = Tools.StringToDateTime(row.Cells[3].Value.ToString());
            pName_textBox.Text = row.Cells[4].Value.ToString();
            portion_numericUpDown.Value = int.Parse(row.Cells[5].Value.ToString());
            amount_numericUpDown.Value = int.Parse(row.Cells[6].Value.ToString());
            calorie_textBox.Text = row.Cells[7].Value.ToString();
            protein_textBox.Text = row.Cells[8].Value.ToString();
            carbohydrate_textBox.Text = row.Cells[9].Value.ToString();
            fat_textBox.Text = row.Cells[10].Value.ToString();
            fiber_textBox.Text = row.Cells[11].Value.ToString();
            cholesterol_textBox.Text = row.Cells[12].Value.ToString();
            sodium_textBox.Text = row.Cells[13].Value.ToString();
            potassium_textBox.Text = row.Cells[14].Value.ToString();
        }

        

        private void dataGridView1_CheckBoxValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if ((Boolean)row.Cells[0].EditedFormattedValue)
                marked_Rows.Add((int)row.Cells[1].Value);
            else
                marked_Rows.Remove((int)row.Cells[1].Value);
        }
        #endregion

        #region TEMP

        private void HideColumns() {
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
        }

        private void open_ToolStripMenuItem_Click(object sender, EventArgs e) {
            string info = Temp.GetInfoSelectedRow(dataGridView1);
            MessageBox.Show(info, "Satır Bilgilendirmesi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void getSelectedRowIndex_button_Click(object sender, EventArgs e) {
            string text = "";
            foreach (int item in marked_Rows) {
                text += " " + item.ToString();
            }

            MessageBox.Show(text);
        }
    }
}
