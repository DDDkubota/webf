using System;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class ConsultarMovimientos : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public ConsultarMovimientos()
        {
            InitializeComponent();
        }




        private void buttonFiltFolio_Click(object sender, EventArgs e)
        {
            if (textBoxFolio.Text == "")
            {

                textBoxFolio.Select(0, textBoxFolio.Text.Length);
                errorProvider1.SetError(textBoxFolio, "Debe introducir el Folio");
            }
            else
            {
                errorProvider1.Clear();
                HistorialMovimientos historialfolio = new HistorialMovimientos();
                String newFolio = textBoxFolio.Text;
                dataGridView1.DataSource = historialfolio.MovimientoxFolio(newFolio);
            }


        }

        private void buttonFiltUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxmatriucla.Text == "")
            {

                textBoxmatriucla.Select(0, textBoxmatriucla.Text.Length);
                errorProvider1.SetError(textBoxmatriucla, "Debe introducir La Matricula o NP");
            }
            if (textBoxmatriucla.Text.Length >= 11)
            {

                textBoxmatriucla.Select(0, textBoxmatriucla.Text.Length);
                errorProvider1.SetError(textBoxmatriucla, "Formato Matricula o NP incorrecta (10 caracteres)");
            }
            else
            {
                errorProvider1.Clear();
                HistorialMovimientos historialmovimientoUsuario = new HistorialMovimientos();
                String filtUsuario = textBoxmatriucla.Text;
                dataGridView1.DataSource = historialmovimientoUsuario.MovimientosxUsuario(filtUsuario);

            }
        }

        private void buttonFiltrFecha_Click(object sender, EventArgs e)
        {
            DateTime datem = dateTimePicker1.Value;
            String formato = "yyyy-MM-dd";

            String dateFinal = datem.ToString(formato);
            HistorialMovimientos HistorialMovFecha = new HistorialMovimientos();
            DataTable consultafecha;
            if (string.IsNullOrEmpty(textBoxmatriucla.Text))
            {
                consultafecha = HistorialMovFecha.MovimientosxFecha(dateFinal);

            }   
            else
            {
                String IDuserFiltro = textBoxmatriucla.Text;
                consultafecha = HistorialMovFecha.MovimientosxUsuarioconFecha(IDuserFiltro, dateFinal);

            }
            dataGridView1.DataSource = consultafecha;


        }

       
    }
}
