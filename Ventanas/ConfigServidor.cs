using System;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class ConfigServidor : Form
    {
        public ConfigServidor()
        {
            InitializeComponent();
            
        }

       

        private void ConfigServidor_Load(object sender, EventArgs e)
        {

            ClassDatosServidor datosser = ClassDatosServidor.instancia();
            string[] array = datosser.leerdocumento();
            textBoxHost.Text = array[0];
            textBoxPort.Text = array[1];
            textBoxNameBD.Text = array[2];
            textBoxuser.Text = array[3];
            textBoxPass.Text = array[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDatosServidor datosser2 = ClassDatosServidor.instancia();
            Boolean respuesta = datosser2.sobreescribirdocs(textBoxHost.Text, textBoxPort.Text, textBoxNameBD.Text, textBoxuser.Text, textBoxPass.Text);
            if (respuesta == true)
            {
                MessageBox.Show("Datos Actualizados con exito");
                ClassDatosServidor nuevosdatos = ClassDatosServidor.instancia();
                string[] datosserv = nuevosdatos.leerdocumento();
                nuevosdatos.server = datosserv[0];
                nuevosdatos.puerto = datosserv[1];
                nuevosdatos.BaseDatos = datosserv[2];
                nuevosdatos.UserDB = datosserv[3];
                nuevosdatos.PassWordDB = datosserv[4];

                this.Close();

            }
            else
            {
                MessageBox.Show("algo salio mal :c");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
