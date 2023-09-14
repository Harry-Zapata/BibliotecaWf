using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca.Capa_Datos;

namespace biblioteca.Capa_Logica
{
    public class CLSLibros_Autor
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;

        public static void InsertarLibrosAutor(Metodo_Libro_Autor LA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "insertarLibro_autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = LA.idLibro;
            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.Char));
            Cm.Parameters["@idAutor"].Value = LA.idAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void ActualizarLibrosAutor(Metodo_Libro_Autor LA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_libro_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = LA.idLibro;
            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.Char));
            Cm.Parameters["@idautor"].Value = LA.idAutor;
            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void BuscarLibrosAutor(Metodo_Libro_Autor LA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "vincular_libro_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", LA.idLibro));
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false) 
            {
                throw new Exception("Libro No Encontrado");
            }
            while (dr.Read()) 
            {
                LA.idLibro = dr[0].ToString();
                LA.nomAutor = dr[1].ToString();
            }Cn.Close();
        }

    }
}