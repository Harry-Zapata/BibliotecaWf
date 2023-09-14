using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca.Capa_Datos;

namespace biblioteca.Capa_Logica
{
    public class CLSAutor
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void LLenarCombox()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "llenar_Autor";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }
        public static void buscarAutor(MetodoAutor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "BUSCAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@idAutor", c.idAutor);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Autor no encontrado!");
            }
            while (dr.Read())
            {
                c.idAutor = dr[0].ToString();
                c.nomAutor = dr[1].ToString();
            }
            Cn.Close();
        }
        public static void ActualizarAutor(MetodoAutor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "EDITAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.Char));
            Cm.Parameters["@idAutor"].Value = c.idAutor;

            Cm.Parameters.Add(new SqlParameter("@nomAutor", SqlDbType.VarChar));
            Cm.Parameters["@nomAutor"].Value = c.nomAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();

        }

        public static void InsertarAutor(MetodoAutor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "INSERTAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.VarChar));
            Cm.Parameters["@idAutor"].Value = c.idAutor;

            Cm.Parameters.Add(new SqlParameter("@nomAutor", SqlDbType.VarChar));
            Cm.Parameters["@nomAutor"].Value = c.nomAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

       
    }

}
