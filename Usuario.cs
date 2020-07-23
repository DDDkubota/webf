using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    class Usuario
    {
        private static Usuario actualusuario;

        public  String UserActivo
        { get; set; }
        public  String TipodeUsuario
        { get; set; }



        public static Usuario newinstance()
        {

            if (actualusuario == null)
            {
                actualusuario = new Usuario();
            }

            return actualusuario;

        }
      public  int validarLogin(String usuario, String password)
        {
            ClassDatosServidor nuevosdatos = ClassDatosServidor.instancia();
            string[] datosserv = nuevosdatos.leerdocumento();
            nuevosdatos.server = datosserv[0];
            nuevosdatos.puerto = datosserv[1];
            nuevosdatos.BaseDatos = datosserv[2];
            nuevosdatos.UserDB = datosserv[3];
            nuevosdatos.PassWordDB = datosserv[4];


            Conexion logNew = Conexion.instancia();


            Boolean res = logNew.Inicarconexion(nuevosdatos.server, nuevosdatos.puerto, nuevosdatos.BaseDatos, nuevosdatos.UserDB, nuevosdatos.PassWordDB);


            if (res == true)
            {

                try
                {
                    MySqlConnection cn = logNew.Abrirconexion();

                    //se hace la consulta para verificar la conexion con el usuario

                    MySqlCommand cmd = new MySqlCommand("SELECT idUsuario, idTipoUsuario, claveAcceso from usuario where idUsuario = @user2 AND claveAcceso= @pass AND idTipoUsuario=2 OR idTipoUsuario=3", cn);
                    cmd.Parameters.AddWithValue("user2", usuario);
                    cmd.Parameters.AddWithValue("pass", password);
                    //añadimos los valores mediante las consultas
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    //creamos una tabla
                    sda.Fill(dt);
                    //llenamos la tabla creada con los datos de la consulta
                    if (dt.Rows.Count >= 1)
                    {
                        //evaluamos si hay registros en la tabla para encontrar concordancias 


                        //mandamos el tipo de usuario que obtivimos de la consulta para ser evaluados




                        int count = dt.Rows.Count;
                        try
                        {
                            for (int i = 0; i <= count; i++)
                            {

                                if (usuario == dt.Rows[i][0].ToString() && password == dt.Rows[i][2].ToString())
                                {
                                    String tipuser = dt.Rows[i][1].ToString();

                                    if (tipuser == "1")
                                    {
                                        return 1;
                                    }

                                   
                                    TipodeUsuario = tipuser;
                                    UserActivo = usuario;

                                    return Int32.Parse(tipuser);
                                    
                                    


                                }


                            }

                        }
                        catch
                        {
                            return 0;
                        }










                    }

                    else
                    {
                        return 0;
                    }

                    cn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Error al conectar la base de datos");
            }
            return 666;
        }

    }
    

}
