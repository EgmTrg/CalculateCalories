namespace CalculateCalories
{
    partial class DetailedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cholesterol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potassium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.ID,
            this.ProductName,
            this.KCalories,
            this.Amount,
            this.Unit,
            this.Carbohydrate,
            this.Protein,
            this.Fat,
            this.Fiber,
            this.Cholesterol,
            this.Sodium,
            this.Potassium});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checkbox.HeaderText = "";
            this.Checkbox.MinimumWidth = 20;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 20;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.Width = 42;
            // 
            // ProductName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.FillWeight = 250F;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 211;
            // 
            // KCalories
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KCalories.DefaultCellStyle = dataGridViewCellStyle3;
            this.KCalories.FillWeight = 90.60093F;
            this.KCalories.HeaderText = "KCal";
            this.KCalories.Name = "KCalories";
            this.KCalories.Width = 77;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 90.60093F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 77;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 90.60093F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 76;
            // 
            // Carbohydrate
            // 
            this.Carbohydrate.FillWeight = 90.60093F;
            this.Carbohydrate.HeaderText = "Carbo.";
            this.Carbohydrate.Name = "Carbohydrate";
            this.Carbohydrate.Width = 77;
            // 
            // Protein
            // 
            this.Protein.FillWeight = 90.60093F;
            this.Protein.HeaderText = "Protein";
            this.Protein.Name = "Protein";
            this.Protein.Width = 76;
            // 
            // Fat
            // 
            this.Fat.FillWeight = 90.60093F;
            this.Fat.HeaderText = "Fat";
            this.Fat.Name = "Fat";
            this.Fat.Width = 77;
            // 
            // Fiber
            // 
            this.Fiber.FillWeight = 90.60093F;
            this.Fiber.HeaderText = "Fiber";
            this.Fiber.Name = "Fiber";
            this.Fiber.Width = 76;
            // 
            // Cholesterol
            // 
            this.Cholesterol.FillWeight = 90.60093F;
            this.Cholesterol.HeaderText = "Cholesterol";
            this.Cholesterol.Name = "Cholesterol";
            this.Cholesterol.Width = 77;
            // 
            // Sodium
            // 
            this.Sodium.FillWeight = 90.60093F;
            this.Sodium.HeaderText = "Sodium";
            this.Sodium.Name = "Sodium";
            this.Sodium.Width = 76;
            // 
            // Potassium
            // 
            this.Potassium.FillWeight = 90.60093F;
            this.Potassium.HeaderText = "Potassium";
            this.Potassium.Name = "Potassium";
            this.Potassium.Width = 77;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 396);
            this.panel1.TabIndex = 6;
            // 
            // DetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 497);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedForm";
            this.Load += new System.EventHandler(this.DetailedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cholesterol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potassium;
        private System.Windows.Forms.Panel panel1;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
    }
}

