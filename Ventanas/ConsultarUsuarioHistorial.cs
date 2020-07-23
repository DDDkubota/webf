using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class ConsultarUsuarioHistorial : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public ConsultarUsuarioHistorial()
        {

            InitializeComponent();
        }

        private void buttonFiltrarUsuario_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                HistorialUsuarios historialUsuarios = new HistorialUsuarios();
                String idusuario = textBoxMatricula.Text;
                dataGridView1.DataSource = historialUsuarios.HistorialUsuarioEnPC(idusuario);
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }

        }

        private void buttonFiltFecha_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime datem = dateTimePicker1.Value;
                String formato = "yyyy-MM-dd";

                String dateFinal = datem.ToString(formato);
                HistorialUsuarios historialUsuarios = new HistorialUsuarios();
                String idusuario2 = textBoxMatricula.Text;
                dataGridView1.DataSource = historialUsuarios.HistorialUsuarioEnPCxFecha(idusuario2, dateFinal);


            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxMatricula, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMatricula.Text == "")
            {
                e.Cancel = true;
                textBoxMatricula.Select(0, textBoxMatricula.Text.Length);
                errorProvider1.SetError(textBoxMatricula, "Debe introducir La Matricula o NP");
            }
            if (textBoxMatricula.Text.Length >= 11)
            {
                e.Cancel = true;
                textBoxMatricula.Select(0, textBoxMatricula.Text.Length);
                errorProvider1.SetError(textBoxMatricula, "Formato Matricula o NP incorrecta (10 caracteres)");
            }

        }

      
    }
}
