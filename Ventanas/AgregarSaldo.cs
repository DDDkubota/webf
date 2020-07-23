using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class AgregarSaldo : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        Conexion agreSalConx = Conexion.instancia();

        public MySqlConnection newConex;

        public AgregarSaldo()
        {


            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                HistorialMovimientos agregarsaldo = new HistorialMovimientos();
                Boolean respuesta = agregarsaldo.agregarsaldo(this.textBoxMatricula.Text, this.textBoxCantidad.Text, this.textBoxFolio.Text);

                if (respuesta == true)
                {
                    MessageBox.Show("Saldo Agregado con Exito a: " + this.textBoxMatricula.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Matricula incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }


        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCaracter v = new ValidacionCaracter();
            v.solonumeros(e);

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFolio, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFolio.Text == "")
            {
                e.Cancel = true;
                textBoxFolio.Select(0, textBoxFolio.Text.Length);
                errorProvider1.SetError(textBoxFolio, "Debe introducir el Folio");
            }
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

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxMatricula, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                e.Cancel = true;
                textBoxCantidad.Select(0, textBoxCantidad.Text.Length);
                errorProvider1.SetError(textBoxCantidad, "introduzca la cantidad");
            }


        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCantidad, "");
        }

      
        

    }
}
