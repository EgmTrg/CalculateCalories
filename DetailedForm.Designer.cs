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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGirdView_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.dataGirdView_contextMenuStrip;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 396);
            this.dataGridView1.TabIndex = 0;
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
            this.delete_ToolStripMenuItem.Click += new System.EventHandler(this.delete_ToolStripMenuItem_Click);
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
            this.insert_button.Location = new System.Drawing.Point(914, 72);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 7;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(995, 72);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Yenile";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(914, 43);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(156, 23);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Delete Selected";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // getSelectedRowIndex_button
            // 
            this.getSelectedRowIndex_button.Location = new System.Drawing.Point(914, 14);
            this.getSelectedRowIndex_button.Name = "getSelectedRowIndex_button";
            this.getSelectedRowIndex_button.Size = new System.Drawing.Size(156, 23);
            this.getSelectedRowIndex_button.TabIndex = 9;
            this.getSelectedRowIndex_button.Text = "Seçili Satır Numarası";
            this.getSelectedRowIndex_button.UseVisualStyleBackColor = true;
            this.getSelectedRowIndex_button.Click += new System.EventHandler(this.getSelectedRowIndex_button_Click);
            // 
            // DetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 497);
            this.Controls.Add(this.getSelectedRowIndex_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.refresh_button);
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
    }
}

