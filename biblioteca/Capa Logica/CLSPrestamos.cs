using biblioteca.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Capa_Logica
{
    public class CLSPrestamos
    {

        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;


        public static void listar_prestamo()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "listar_prestamo";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar prestamo");
            Cn.Close();
        }
        public static void listarPrestadosSinAnular() 
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VlistarConsultarLibros";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar prestamo sin anular");
            Cn.Close();
        }
        public static void InsertarPrestamo(MetodoPrestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_prestamo";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = c.idLibro;

            Cm.Parameters.Add(new SqlParameter("@fechaP", SqlDbType.DateTime));
            Cm.Parameters["@fechaP"].Value = c.fechaP;

            Cm.Parameters.Add(new SqlParameter("@fechaD", SqlDbType.DateTime));
            Cm.Parameters["@fechaD"].Value = c.fechaD;

            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.anulado;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void AnularPrestamos(MetodoPrestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Anular_prestamo";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = c.idLibro;

            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.anulado;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        public static void BuscarPorInicio(MetodoPrestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultarLibroFechaI";
            da.SelectCommand.Parameters.AddWithValue("@fechaI", c.fechaP);
            da.SelectCommand.Parameters.AddWithValue("@fechaF", c.fechaD);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Inicio");
            Cn.Close();
        }
        public static void BuscarPorFin(MetodoPrestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultarLibroFin";
            da.SelectCommand.Parameters.AddWithValue("@fechaI", c.fechaP);
            da.SelectCommand.Parameters.AddWithValue("@fechaF", c.fechaD);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Fin");
            Cn.Close();
        }
    }
}
