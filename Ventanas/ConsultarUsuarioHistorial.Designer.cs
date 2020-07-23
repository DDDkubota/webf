namespace programaweb24
{
    partial class ConsultarUsuarioHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuarioHistorial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.buttonFiltrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFiltFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 200);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(173)))), ((int)(((byte)(86)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 144);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(35, 84);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(266, 25);
            this.textBoxMatricula.TabIndex = 2;
            this.textBoxMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBoxMatricula.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // buttonFiltrarUsuario
            // 
            this.buttonFiltrarUsuario.Location = new System.Drawing.Point(322, 81);
            this.buttonFiltrarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFiltrarUsuario.Name = "buttonFiltrarUsuario";
            this.buttonFiltrarUsuario.Size = new System.Drawing.Size(151, 30);
            this.buttonFiltrarUsuario.TabIndex = 3;
            this.buttonFiltrarUsuario.Text = "Filtrar por Usuario";
            this.buttonFiltrarUsuario.UseVisualStyleBackColor = true;
            this.buttonFiltrarUsuario.Click += new System.EventHandler(this.buttonFiltrarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula o NP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha ";
            // 
            // buttonFiltFecha
            // 
            this.buttonFiltFecha.Location = new System.Drawing.Point(322, 140);
            this.buttonFiltFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFiltFecha.Name = "buttonFiltFecha";
            this.buttonFiltFecha.Size = new System.Drawing.Size(151, 30);
            this.buttonFiltFecha.TabIndex = 6;
            this.buttonFiltFecha.Text = "Filtrar por Fecha";
            this.buttonFiltFecha.UseVisualStyleBackColor = true;
            this.buttonFiltFecha.Click += new System.EventHandler(this.buttonFiltFecha_Click);
            // 
            // ConsultarUsuarioHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(747, 536);
            this.Controls.Add(this.buttonFiltFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFiltrarUsuario);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultarUsuarioHistorial";
            this.Text = "Consultar Historial de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Button buttonFiltrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFiltFecha;
    }
}