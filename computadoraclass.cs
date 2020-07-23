using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace programaweb24
{
    public class computadoraclass
    {
        private Conexion porconex = Conexion.instancia();
        private MySqlCommand camndo = new MySqlCommand();
        private MySqlDataReader leerfilas;




        public DataTable listarPC()
        {


            DataTable tabla = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "ListarComputadora";
            camndo.CommandType = CommandType.StoredProcedure;
            leerfilas = camndo.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tabla;
        }
        public Boolean cambiarEstado(String ID, String estado)
        {
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "BLOQ/DESBLOPC";
            camndo.CommandType = CommandType.StoredProcedure;

            if (estado == "BLOQUEADO")
            {
                camndo.Parameters.AddWithValue("_estado", 3);

            }
            else
            {
                camndo.Parameters.AddWithValue("_estado", 2);
            }
            camndo.Parameters.AddWithValue("_id", ID);
            int respusta = camndo.ExecuteNonQuery();

            if (respusta == 1)
            {
                porconex.Cerrarconexion();
                return true;
            }
            else
            {
                porconex.Cerrarconexion();
                return false;
            }

        }
        public DataTable HistorialPC(String id)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "HistorialdePC";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_ID", id);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tablaHistorial;
        }
        public DataTable HistorialPCxFecha(String id, String date)
        {
            DataTable tablaHistorialFecha = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "HistorialdePCFecha";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_ID", id);
            camndo.Parameters.AddWithValue("_fecha", date);

            leerfilas = camndo.ExecuteReader();
            tablaHistorialFecha.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();


            return tablaHistorialFecha;
        }


    }
}
