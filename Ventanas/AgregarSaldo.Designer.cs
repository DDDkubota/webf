namespace programaweb24
{
    partial class AgregarSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarSaldo));
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxFolio = new System.Windows.Forms.TextBox();
            this.buttonAgreSaldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxMatricula.BackColor = System.Drawing.Color.White;
            this.textBoxMatricula.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMatricula.Location = new System.Drawing.Point(347, 88);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(262, 25);
            this.textBoxMatricula.TabIndex = 1;
            this.textBoxMatricula.Text = "Respetar Mayusculas/Minusculas";
            this.textBoxMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBoxMatricula.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCantidad.Location = new System.Drawing.Point(347, 148);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(262, 25);
            this.textBoxCantidad.TabIndex = 2;
            this.textBoxCantidad.Text = "Solo numeros";
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBoxCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.textBoxCantidad.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.Location = new System.Drawing.Point(347, 212);
            this.textBoxFolio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.Size = new System.Drawing.Size(262, 25);
            this.textBoxFolio.TabIndex = 3;
            this.textBoxFolio.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            this.textBoxFolio.Validated += new System.EventHandler(this.textBox3_Validated);
            // 
            // buttonAgreSaldo
            // 
            this.buttonAgreSaldo.Location = new System.Drawing.Point(422, 289);
            this.buttonAgreSaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgreSaldo.Name = "buttonAgreSaldo";
            this.buttonAgreSaldo.Size = new System.Drawing.Size(120, 30);
            this.buttonAgreSaldo.TabIndex = 4;
            this.buttonAgreSaldo.Text = "Agregar Saldo";
            this.buttonAgreSaldo.UseVisualStyleBackColor = true;
            this.buttonAgreSaldo.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(182, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricula/NP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de Folio";
            // 
            // AgregarSaldo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(769, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgreSaldo);
            this.Controls.Add(this.textBoxFolio);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxMatricula);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgregarSaldo";
            this.Text = "Agregar Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxFolio;
        private System.Windows.Forms.Button buttonAgreSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}