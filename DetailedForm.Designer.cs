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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGirdView_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.getSelectedRowIndex_button = new System.Windows.Forms.Button();
            this.refresh_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.portion_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.calorie_textBox = new System.Windows.Forms.TextBox();
            this.protein_textBox = new System.Windows.Forms.TextBox();
            this.carbohydrate_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cholesterol_textBox = new System.Windows.Forms.TextBox();
            this.potassium_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sodium_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fiber_textBox = new System.Windows.Forms.TextBox();
            this.fat_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.AutoProduct_checkBox = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seciliSatirNumarasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGirdView_contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portion_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 357);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.dataGirdView_contextMenuStrip;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // dataGirdView_contextMenuStrip
            // 
            this.dataGirdView_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh_ToolStripMenuItem,
            this.delete_ToolStripMenuItem,
            this.open_ToolStripMenuItem});
            this.dataGirdView_contextMenuStrip.Name = "dataGirdView_contextMenuStrip";
            this.dataGirdView_contextMenuStrip.Size = new System.Drawing.Size(106, 70);
            // 
            // refresh_ToolStripMenuItem
            // 
            this.refresh_ToolStripMenuItem.Name = "refresh_ToolStripMenuItem";
            this.refresh_ToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.refresh_ToolStripMenuItem.Text = "Yenile";
            this.refresh_ToolStripMenuItem.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // delete_ToolStripMenuItem
            // 
            this.delete_ToolStripMenuItem.Name = "delete_ToolStripMenuItem";
            this.delete_ToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.delete_ToolStripMenuItem.Text = "Sil";
            this.delete_ToolStripMenuItem.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // open_ToolStripMenuItem
            // 
            this.open_ToolStripMenuItem.Name = "open_ToolStripMenuItem";
            this.open_ToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.open_ToolStripMenuItem.Text = "Aç";
            this.open_ToolStripMenuItem.Click += new System.EventHandler(this.open_ToolStripMenuItem_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(914, 100);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 36);
            this.insert_button.TabIndex = 7;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(995, 100);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 36);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Yenile";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(995, 58);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 36);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Delete Selected";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // getSelectedRowIndex_button
            // 
            this.getSelectedRowIndex_button.Location = new System.Drawing.Point(914, 16);
            this.getSelectedRowIndex_button.Name = "getSelectedRowIndex_button";
            this.getSelectedRowIndex_button.Size = new System.Drawing.Size(156, 36);
            this.getSelectedRowIndex_button.TabIndex = 9;
            this.getSelectedRowIndex_button.Text = "Seçili Satır Numarası";
            this.getSelectedRowIndex_button.UseVisualStyleBackColor = true;
            // 
            // refresh_checkBox
            // 
            this.refresh_checkBox.AutoSize = true;
            this.refresh_checkBox.Checked = true;
            this.refresh_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refresh_checkBox.Location = new System.Drawing.Point(17, 46);
            this.refresh_checkBox.Name = "refresh_checkBox";
            this.refresh_checkBox.Size = new System.Drawing.Size(146, 17);
            this.refresh_checkBox.TabIndex = 10;
            this.refresh_checkBox.Text = "Her işlemden sonra yenile";
            this.refresh_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID_numericUpDown);
            this.groupBox1.Controls.Add(this.amount_numericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.portion_numericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pName_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Olmasi Gerekenler";
            // 
            // ID_numericUpDown
            // 
            this.ID_numericUpDown.Location = new System.Drawing.Point(43, 69);
            this.ID_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ID_numericUpDown.Name = "ID_numericUpDown";
            this.ID_numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ID_numericUpDown.TabIndex = 7;
            // 
            // amount_numericUpDown
            // 
            this.amount_numericUpDown.Location = new System.Drawing.Point(213, 91);
            this.amount_numericUpDown.Name = "amount_numericUpDown";
            this.amount_numericUpDown.Size = new System.Drawing.Size(52, 20);
            this.amount_numericUpDown.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // portion_numericUpDown
            // 
            this.portion_numericUpDown.Location = new System.Drawing.Point(152, 91);
            this.portion_numericUpDown.Name = "portion_numericUpDown";
            this.portion_numericUpDown.Size = new System.Drawing.Size(52, 20);
            this.portion_numericUpDown.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Portion";
            // 
            // pName_textBox
            // 
            this.pName_textBox.Location = new System.Drawing.Point(6, 43);
            this.pName_textBox.Name = "pName_textBox";
            this.pName_textBox.Size = new System.Drawing.Size(259, 20);
            this.pName_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(43, 91);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calorie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Protein";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Carbohydrate";
            // 
            // calorie_textBox
            // 
            this.calorie_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calorie_textBox.Location = new System.Drawing.Point(82, 23);
            this.calorie_textBox.Name = "calorie_textBox";
            this.calorie_textBox.Size = new System.Drawing.Size(65, 20);
            this.calorie_textBox.TabIndex = 8;
            // 
            // protein_textBox
            // 
            this.protein_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.protein_textBox.Location = new System.Drawing.Point(82, 49);
            this.protein_textBox.Name = "protein_textBox";
            this.protein_textBox.Size = new System.Drawing.Size(65, 20);
            this.protein_textBox.TabIndex = 9;
            // 
            // carbohydrate_textBox
            // 
            this.carbohydrate_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbohydrate_textBox.Location = new System.Drawing.Point(82, 75);
            this.carbohydrate_textBox.Name = "carbohydrate_textBox";
            this.carbohydrate_textBox.Size = new System.Drawing.Size(65, 20);
            this.carbohydrate_textBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cholesterol_textBox);
            this.groupBox2.Controls.Add(this.potassium_textBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.sodium_textBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.fiber_textBox);
            this.groupBox2.Controls.Add(this.fat_textBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.carbohydrate_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.protein_textBox);
            this.groupBox2.Controls.Add(this.calorie_textBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detaylar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Potassium";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(272, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cholesterol";
            // 
            // cholesterol_textBox
            // 
            this.cholesterol_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cholesterol_textBox.Location = new System.Drawing.Point(337, 49);
            this.cholesterol_textBox.Name = "cholesterol_textBox";
            this.cholesterol_textBox.Size = new System.Drawing.Size(65, 20);
            this.cholesterol_textBox.TabIndex = 21;
            // 
            // potassium_textBox
            // 
            this.potassium_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.potassium_textBox.Location = new System.Drawing.Point(337, 23);
            this.potassium_textBox.Name = "potassium_textBox";
            this.potassium_textBox.Size = new System.Drawing.Size(65, 20);
            this.potassium_textBox.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Sodium";
            // 
            // sodium_textBox
            // 
            this.sodium_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sodium_textBox.Location = new System.Drawing.Point(201, 75);
            this.sodium_textBox.Name = "sodium_textBox";
            this.sodium_textBox.Size = new System.Drawing.Size(65, 20);
            this.sodium_textBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(153, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Fat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fiber";
            // 
            // fiber_textBox
            // 
            this.fiber_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiber_textBox.Location = new System.Drawing.Point(201, 49);
            this.fiber_textBox.Name = "fiber_textBox";
            this.fiber_textBox.Size = new System.Drawing.Size(65, 20);
            this.fiber_textBox.TabIndex = 15;
            // 
            // fat_textBox
            // 
            this.fat_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fat_textBox.Location = new System.Drawing.Point(201, 23);
            this.fat_textBox.Name = "fat_textBox";
            this.fat_textBox.Size = new System.Drawing.Size(65, 20);
            this.fat_textBox.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.AutoProduct_checkBox);
            this.groupBox3.Controls.Add(this.refresh_checkBox);
            this.groupBox3.Location = new System.Drawing.Point(720, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 122);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ayarlar";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(17, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(146, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Her işlemden sonra yenile";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(17, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(146, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Her işlemden sonra yenile";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // AutoProduct_checkBox
            // 
            this.AutoProduct_checkBox.AutoSize = true;
            this.AutoProduct_checkBox.Checked = true;
            this.AutoProduct_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoProduct_checkBox.Location = new System.Drawing.Point(17, 23);
            this.AutoProduct_checkBox.Name = "AutoProduct_checkBox";
            this.AutoProduct_checkBox.Size = new System.Drawing.Size(139, 17);
            this.AutoProduct_checkBox.TabIndex = 10;
            this.AutoProduct_checkBox.Text = "Otomatik Rastgele Ürün";
            this.AutoProduct_checkBox.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(914, 58);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 36);
            this.update_button.TabIndex = 7;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seciliSatirNumarasiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 26);
            // 
            // seciliSatirNumarasiToolStripMenuItem
            // 
            this.seciliSatirNumarasiToolStripMenuItem.Name = "seciliSatirNumarasiToolStripMenuItem";
            this.seciliSatirNumarasiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.seciliSatirNumarasiToolStripMenuItem.Text = "Secili satir numarasi";
            // 
            // DetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getSelectedRowIndex_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedForm";
            this.Load += new System.EventHandler(this.DetailedForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGirdView_contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portion_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.ContextMenuStrip dataGirdView_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_ToolStripMenuItem;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button getSelectedRowIndex_button;
        private System.Windows.Forms.CheckBox refresh_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown amount_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown portion_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pName_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox calorie_textBox;
        private System.Windows.Forms.TextBox protein_textBox;
        private System.Windows.Forms.TextBox carbohydrate_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox cholesterol_textBox;
        private System.Windows.Forms.TextBox potassium_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sodium_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox fiber_textBox;
        private System.Windows.Forms.TextBox fat_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox AutoProduct_checkBox;
        private System.Windows.Forms.NumericUpDown ID_numericUpDown;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seciliSatirNumarasiToolStripMenuItem;
    }
}

