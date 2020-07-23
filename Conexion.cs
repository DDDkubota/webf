using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    class Conexion
    {
        ClassDatosServidor datosserv = ClassDatosServidor.instancia();

        MySqlConnection Conex;
        static Conexion instance;
        public static Conexion instancia()
        {
            if (null == instance)
            {
                instance = new Conexion();
            }
            return instance;

        }









        public Boolean Inicarconexion(String server, String puerto, String DBname, String DBUser, String DBPass)
        {


            string V = "SERVER=" + server + ";PORT=" + puerto + ";DATABASE=" + DBname + ";UID=" + DBUser + ";PASSWORD=" + DBPass + ";old guids=true;";


            Conex = new MySqlConnection(V);
            try
            {
                Conex.Open();
                Conex.Close();
                return true;
            }
            catch (MySqlException)
            {
               
                return false;
            }




        }




        public MySqlConnection Abrirconexion()
        {


            if (Conex.State == ConnectionState.Closed)
            {


                Conex.Open();





            }

            return Conex;

        }
        public MySqlConnection Cerrarconexion()
        {

            if (Conex.State == ConnectionState.Open)
            {
                Conex.Close();
            }

            return Conex;
        }



    }


}
