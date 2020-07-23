namespace programaweb24
{
    partial class ConsultarMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMovimientos));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxmatriucla = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFiltrFecha = new System.Windows.Forms.Button();
            this.buttonFiltUsuario = new System.Windows.Forms.Button();
            this.textBoxFolio = new System.Windows.Forms.TextBox();
            this.buttonFiltFolio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBoxmatriucla
            // 
            this.textBoxmatriucla.Location = new System.Drawing.Point(16, 109);
            this.textBoxmatriucla.Name = "textBoxmatriucla";
            this.textBoxmatriucla.Size = new System.Drawing.Size(263, 25);
            this.textBoxmatriucla.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(173)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(632, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonFiltrFecha
            // 
            this.buttonFiltrFecha.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.buttonFiltrFecha.Location = new System.Drawing.Point(326, 167);
            this.buttonFiltrFecha.Name = "buttonFiltrFecha";
            this.buttonFiltrFecha.Size = new System.Drawing.Size(167, 31);
            this.buttonFiltrFecha.TabIndex = 3;
            this.buttonFiltrFecha.Text = "Filtrar por Fecha";
            this.buttonFiltrFecha.UseVisualStyleBackColor = true;
            this.buttonFiltrFecha.Click += new System.EventHandler(this.buttonFiltrFecha_Click);
            // 
            // buttonFiltUsuario
            // 
            this.buttonFiltUsuario.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.buttonFiltUsuario.Location = new System.Drawing.Point(326, 105);
            this.buttonFiltUsuario.Name = "buttonFiltUsuario";
            this.buttonFiltUsuario.Size = new System.Drawing.Size(167, 31);
            this.buttonFiltUsuario.TabIndex = 4;
            this.buttonFiltUsuario.Text = "Filtrar por Usuario";
            this.buttonFiltUsuario.UseVisualStyleBackColor = true;
            this.buttonFiltUsuario.Click += new System.EventHandler(this.buttonFiltUsuario_Click);
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.Location = new System.Drawing.Point(17, 48);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(262, 25);
            this.textBoxFolio.TabIndex = 5;
            // 
            // buttonFiltFolio
            // 
            this.buttonFiltFolio.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.buttonFiltFolio.Location = new System.Drawing.Point(326, 48);
            this.buttonFiltFolio.Name = "buttonFiltFolio";
            this.buttonFiltFolio.Size = new System.Drawing.Size(167, 31);
            this.buttonFiltFolio.TabIndex = 6;
            this.buttonFiltFolio.Text = "Filtrar por Folio";
            this.buttonFiltFolio.UseVisualStyleBackColor = true;
            this.buttonFiltFolio.Click += new System.EventHandler(this.buttonFiltFolio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricula/NP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folio";
            // 
            // ConsultarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFiltFolio);
            this.Controls.Add(this.textBoxFolio);
            this.Controls.Add(this.buttonFiltUsuario);
            this.Controls.Add(this.buttonFiltrFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxmatriucla);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarMovimientos";
            this.Text = "Consultar Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxmatriucla;
        private System.Windows.Forms.Button buttonFiltrFecha;
        private System.Windows.Forms.Button buttonFiltUsuario;
        private System.Windows.Forms.TextBox textBoxFolio;
        private System.Windows.Forms.Button buttonFiltFolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DataGridView dataGridView1;
    }
}