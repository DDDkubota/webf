using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //se establece conexion con la base de datos


      


        private void btnstartsesion_Click(object sender, EventArgs e)
        {
          
            Usuario veruser = Usuario.newinstance();
           int respuesta= veruser.validarLogin(this.txtuser.Text, this.txtpass.Text);
            switch (respuesta)
            {
                case 1:
                    MessageBox.Show("Usuario sin autoridad de acceso");
                    break;
                case 0:
                    MessageBox.Show("Usuario/Contraseña Incorrextos");

                    break;
                case 666:
                    MessageBox.Show("ERROR AL CONECTAR CON EL SERVIDOR VERIFIQUE CONEXION");
                    break;
                default:
                 String tipuser = respuesta.ToString();
                 new Menu(ref tipuser).Show();
                    this.Close();
                    break;

            }
           
            

        }

        
        private void buttonServ_Click(object sender, EventArgs e)
        {
            new ConfigServidor().ShowDialog();

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
