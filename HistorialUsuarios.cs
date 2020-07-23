using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace programaweb24
{
    class HistorialUsuarios
    {
        private Conexion porconex = Conexion.instancia();
        private MySqlCommand camndo = new MySqlCommand();
        private MySqlCommand camndo2 = new MySqlCommand();
        private MySqlDataReader leerfilas;
        public DataTable HistorialUsuarioEnPC(String IdUsuario)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "HistorialPCdeUsuario";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_Idusuario", IdUsuario);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();
            
            return tablaHistorial;
        }
        public DataTable HistorialUsuarioEnPCxFecha(String IdUsuario2, String date)
        {
            DataTable tablaHistorialFecha = new DataTable();
            camndo2.Connection = porconex.Abrirconexion();
            camndo2.CommandText = "HistorialPCdeUsuarioFecha";
            camndo2.CommandType = CommandType.StoredProcedure;
            camndo2.Parameters.AddWithValue("_Idusuario", IdUsuario2);
            camndo2.Parameters.AddWithValue("_fecha", date);
            try
            {
                leerfilas = camndo2.ExecuteReader();


                tablaHistorialFecha.Load(leerfilas);
                leerfilas.Close();
                porconex.Cerrarconexion();


                return tablaHistorialFecha;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Matriucula invalida");
                return tablaHistorialFecha;
            }

        }
        public  int validarsuspender(String IdUsuario)
        {

            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "obtenerestado";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_Idusuario", IdUsuario);

            MySqlDataAdapter sda = new MySqlDataAdapter(camndo);
            DataTable dt = new DataTable();
            int estado;
            //creamos una tabla
            sda.Fill(dt);
            porconex.Cerrarconexion();
            if (dt.Rows.Count != 1)
            {
                
                return 0;
            }
            else { 
            switch (dt.Rows[0][0])
                {
                    case 1:
                        estado = 2;
                        break;
                    default:
                        estado = 3;
                        break;


                }
            
            
            
            }
            camndo2.Connection = porconex.Abrirconexion();
            camndo2.CommandText = "ValidarSuspenderUser";
            camndo.CommandType = CommandType.StoredProcedure;

            camndo2.Parameters.AddWithValue("estado_", estado);
            camndo2.Parameters.AddWithValue("_Idusuario", IdUsuario);
            if (camndo2.ExecuteNonQuery()==1)
            {
                porconex.Cerrarconexion();
                return 1;
            }
            

            porconex.Cerrarconexion();
            return 2;
            
        }
    }
}