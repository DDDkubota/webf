using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace programaweb24
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }
        //se establece conexion con la base de datos
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=web;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public void loginv(string usuario, string password)
        {
            try
            {
                //se hace la consulta para verificar la conexion con el usuario
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT user, tipo_user, pass from users where user = @user2 AND pass= @pass", cn);
                cmd.Parameters.AddWithValue("user2", usuario);
                cmd.Parameters.AddWithValue("pass", password);
                //añadimos los valores mediante las consultas
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //creamos una tabla
                sda.Fill(dt);
                //llenamos la tabla creada con los datos de la consulta
                if (dt.Rows.Count==1)
                    //evaluamos si hay registros en la tabla para encontrar concordancias 
                {
                    //mandamos el tipo de usuario que obtivimos de la consulta para ser evaluados
                    String tipuser = dt.Rows[0][1].ToString();
                    new Form1(ref tipuser).Show();


                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                } 


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        
        private void btnstartsesion_Click(object sender, EventArgs e)
        {
            loginv(this.txtuser.Text,this.txtpass.Text);

        }


       
    }
}
