namespace CalculateCalories
{
    partial class App
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
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newData_button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // id_textBox
            // 
            this.id_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_textBox.Enabled = false;
            this.id_textBox.Location = new System.Drawing.Point(34, 30);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(86, 20);
            this.id_textBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(296, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newData_button);
            this.panel1.Controls.Add(this.clear_Button);
            this.panel1.Controls.Add(this.refresh_Button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 78);
            this.panel1.TabIndex = 6;
            // 
            // newData_button
            // 
            this.newData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newData_button.Location = new System.Drawing.Point(440, 10);
            this.newData_button.Name = "newData_button";
            this.newData_button.Size = new System.Drawing.Size(100, 61);
            this.newData_button.TabIndex = 9;
            this.newData_button.Text = "Yeni Satir Ekle";
            this.newData_button.UseVisualStyleBackColor = true;
            this.newData_button.Click += new System.EventHandler(this.newData_button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(544, 10);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(100, 30);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Filtreyi Temizle";
            this.clear_Button.UseVisualStyleBackColor = true;
            // 
            // refresh_Button
            // 
            this.refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_Button.Location = new System.Drawing.Point(544, 41);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.Size = new System.Drawing.Size(100, 30);
            this.refresh_Button.TabIndex = 1;
            this.refresh_Button.Text = "Yenile";
            this.refresh_Button.UseVisualStyleBackColor = true;
            this.refresh_Button.Click += new System.EventHandler(this.refresh_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.id_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tarih:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.table);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 393);
            this.panel2.TabIndex = 7;
            // 
            // table
            // 
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(654, 393);
            this.table.TabIndex = 0;
            this.table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(670, 510);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button refresh_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newData_button;
    }
}