namespace programaweb24
{
    partial class HistorialPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPC));
            this.dataGridView13 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ButtonFiltrarFecha = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDescrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView13
            // 
            this.dataGridView13.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView13.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.dataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView13.Location = new System.Drawing.Point(16, 46);
            this.dataGridView13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView13.Name = "dataGridView13";
            this.dataGridView13.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(173)))), ((int)(((byte)(86)))));
            this.dataGridView13.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView13.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView13.Size = new System.Drawing.Size(420, 207);
            this.dataGridView13.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 277);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // ButtonFiltrarFecha
            // 
            this.ButtonFiltrarFecha.Location = new System.Drawing.Point(306, 277);
            this.ButtonFiltrarFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonFiltrarFecha.Name = "ButtonFiltrarFecha";
            this.ButtonFiltrarFecha.Size = new System.Drawing.Size(130, 30);
            this.ButtonFiltrarFecha.TabIndex = 3;
            this.ButtonFiltrarFecha.Text = "Filtrar por Fecha";
            this.ButtonFiltrarFecha.UseVisualStyleBackColor = true;
            this.ButtonFiltrarFecha.Click += new System.EventHandler(this.FiltrarFecha_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(32, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 17);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "label1";
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Location = new System.Drawing.Point(303, 17);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(42, 17);
            this.labelDescrip.TabIndex = 5;
            this.labelDescrip.Text = "label2";
            // 
            // HistorialPC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(591, 337);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.ButtonFiltrarFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView13);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistorialPC";
            this.Text = "Hisotorial de PC";
            this.Load += new System.EventHandler(this.HistorialPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ButtonFiltrarFecha;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDescrip;
    }
}