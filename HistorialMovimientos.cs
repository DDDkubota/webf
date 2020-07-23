using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace programaweb24
{
    class HistorialMovimientos
    {
        private Conexion porconex = Conexion.instancia();
        private MySqlCommand camndo = new MySqlCommand();
        MySqlCommand updatesaldo = new MySqlCommand();
        MySqlCommand addmovi = new MySqlCommand();
        private MySqlDataReader leerfilas;
      
        public Boolean agregarsaldo(String IdUsuario,String Saldon,String folio)
        {
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText= "SELECT saldo from usuario where idUsuario = @user2";
            camndo.Parameters.AddWithValue("user2", IdUsuario);
            MySqlDataAdapter sda = new MySqlDataAdapter(camndo);
            DataTable dt = new DataTable();
            //creamos una tabla
            sda.Fill(dt);

            //llenamos la tabla creada con los datos de la consulta
            if (dt.Rows.Count == 1)
            {
                String saldov = dt.Rows[0][0].ToString();
                camndo.Connection=porconex.Cerrarconexion();
                float saldoviejo = float.Parse(saldov);
                float saldoagregado = float.Parse(Saldon);
                float nuevosaldo = saldoagregado + saldoviejo;
                updatesaldo.Connection = porconex.Abrirconexion();

                updatesaldo.CommandText = "UPDATE usuario SET saldo=@newsaldo where idUsuario = @user2";
                updatesaldo.Parameters.AddWithValue("user2", IdUsuario);
                updatesaldo.Parameters.AddWithValue("newsaldo", nuevosaldo);
                updatesaldo.ExecuteNonQuery();
                updatesaldo.Connection = porconex.Cerrarconexion();
                addmovi.Connection = porconex.Abrirconexion();

                addmovi.CommandText = "INSERT INTO movimiento (idUsuario, idServicio, referencia, valor_mov) VALUES (@user2, 1, @folio, @valor)";

                addmovi.Parameters.AddWithValue("user2", IdUsuario);
                addmovi.Parameters.AddWithValue("folio", folio);
                addmovi.Parameters.AddWithValue("valor", saldoagregado);
                addmovi.ExecuteNonQuery();


            
            return true;
        }
            else
            {
                return false;

            }

        }

        public DataTable MovimientoxFolio(String folio)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "MovimientosxFolio";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_folio", folio);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tablaHistorial;
        }
        public DataTable MovimientosxFecha(String date)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "MovimientosxFecha";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_date", date);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tablaHistorial;
        }
        public DataTable MovimientosxUsuario(String idUsuaario)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "MovimientosxUsuario";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_Idusuario", idUsuaario);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tablaHistorial;
        }
        public DataTable MovimientosxUsuarioconFecha(String idUsuaario2, String date2)
        {


            DataTable tablaHistorial = new DataTable();
            camndo.Connection = porconex.Abrirconexion();
            camndo.CommandText = "MovimientosxUsuarioconFecha";
            camndo.CommandType = CommandType.StoredProcedure;
            camndo.Parameters.AddWithValue("_Idusuario", idUsuaario2);
            camndo.Parameters.AddWithValue("_fecha", date2);
            leerfilas = camndo.ExecuteReader();
            tablaHistorial.Load(leerfilas);
            leerfilas.Close();
            porconex.Cerrarconexion();

            return tablaHistorial;
        }


    }
}
