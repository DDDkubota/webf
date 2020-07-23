using programaweb24.Ventanas;
using System;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class Menu : Form
    {
        //verificamos que tipo de usuario es Para dar acceso a ciertas partes del menu 
        public Menu(ref String b)
        {
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            InitializeComponent();

            //si es un moderador ocultaremos las siguientes opciones del menu 
            if (b == "2")
            {
                buttonAgregarSaldo.Hide();

                labelTipouser.Text = "MODERADOR";
            }
            else
            {
                labelTipouser.Text = "ADMINISTRADOR";
            }
            Usuario veruser = Usuario.newinstance();
            String nombre = veruser.UserActivo;
            label1user.Text = "Usuario : " + nombre;

        }


        private void button2_Click(object sender, EventArgs e)

        {
            new AgregarSaldo().ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
            this.MinimizeBox = true;

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
            new Control_PC().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ConsultarUsuarioHistorial().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new ConsultarMovimientos().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modUserAdmin_Click(object sender, EventArgs e)
        {
            new Validarusuario().ShowDialog();
        }
    }
}
