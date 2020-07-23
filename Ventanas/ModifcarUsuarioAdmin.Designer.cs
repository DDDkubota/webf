namespace programaweb24.Ventanas
{
    partial class ModifcarUsuarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifcarUsuarioAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.buttonValidarMatricula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(209, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula a Validar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBoxMatricula.Location = new System.Drawing.Point(199, 141);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(147, 25);
            this.textBoxMatricula.TabIndex = 1;
            // 
            // buttonValidarMatricula
            // 
            this.buttonValidarMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.buttonValidarMatricula.Location = new System.Drawing.Point(167, 202);
            this.buttonValidarMatricula.Name = "buttonValidarMatricula";
            this.buttonValidarMatricula.Size = new System.Drawing.Size(75, 23);
            this.buttonValidarMatricula.TabIndex = 2;
            this.buttonValidarMatricula.Text = "Validar Matricula";
            this.buttonValidarMatricula.UseVisualStyleBackColor = true;
            // 
            // ModifcarUsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programaweb24.Properties.Resources._78644d164cd335c27b50485eea58b903__1_;
            this.ClientSize = new System.Drawing.Size(531, 322);
            this.Controls.Add(this.buttonValidarMatricula);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifcarUsuarioAdmin";
            this.Text = "ModifcarUsuarioAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Button buttonValidarMatricula;
    }
}