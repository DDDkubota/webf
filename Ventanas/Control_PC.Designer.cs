namespace programaweb24
{
    partial class Control_PC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_PC));
            this.buttonBLOQUEARPC = new System.Windows.Forms.Button();
            this.buttonHistorialPC = new System.Windows.Forms.Button();
            this.buttonBackmenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBLOQUEARPC
            // 
            this.buttonBLOQUEARPC.Location = new System.Drawing.Point(16, 29);
            this.buttonBLOQUEARPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBLOQUEARPC.Name = "buttonBLOQUEARPC";
            this.buttonBLOQUEARPC.Size = new System.Drawing.Size(177, 30);
            this.buttonBLOQUEARPC.TabIndex = 1;
            this.buttonBLOQUEARPC.Text = "Bloquear/Desbloquear PC";
            this.buttonBLOQUEARPC.UseVisualStyleBackColor = true;
            this.buttonBLOQUEARPC.Click += new System.EventHandler(this.buttonBLOQUEARPC_Click);
            // 
            // buttonHistorialPC
            // 
            this.buttonHistorialPC.Location = new System.Drawing.Point(16, 98);
            this.buttonHistorialPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHistorialPC.Name = "buttonHistorialPC";
            this.buttonHistorialPC.Size = new System.Drawing.Size(177, 30);
            this.buttonHistorialPC.TabIndex = 2;
            this.buttonHistorialPC.Text = "Historial PC";
            this.buttonHistorialPC.UseVisualStyleBackColor = true;
            this.buttonHistorialPC.Click += new System.EventHandler(this.buttonHistorialPC_Click);
            // 
            // buttonBackmenu
            // 
            this.buttonBackmenu.Location = new System.Drawing.Point(3, 360);
            this.buttonBackmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBackmenu.Name = "buttonBackmenu";
            this.buttonBackmenu.Size = new System.Drawing.Size(99, 30);
            this.buttonBackmenu.TabIndex = 3;
            this.buttonBackmenu.Text = "Regresar";
            this.buttonBackmenu.UseVisualStyleBackColor = true;
            this.buttonBackmenu.Click += new System.EventHandler(this.buttonBackmenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(173)))), ((int)(((byte)(86)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 286);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(16, 158);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(177, 30);
            this.buttonActualizar.TabIndex = 5;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // Control_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(889, 398);
            this.ControlBox = false;
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBackmenu);
            this.Controls.Add(this.buttonHistorialPC);
            this.Controls.Add(this.buttonBLOQUEARPC);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Control_PC";
            this.Text = "Control de  Equipos";
            this.Load += new System.EventHandler(this.Control_PC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBLOQUEARPC;
        private System.Windows.Forms.Button buttonHistorialPC;
        private System.Windows.Forms.Button buttonBackmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonActualizar;
    }
}