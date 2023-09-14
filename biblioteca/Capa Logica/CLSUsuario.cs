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
    public class CLSUsuario
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Login(MetodoUsuario c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "verificar_usuario";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@nomUsuario", c.usuario));
            Cm.Parameters.Add(new SqlParameter("@passUsuario", c.contraseña));
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("No Encontrado");
            }
            while (dr.Read())
            {
                c.usuario = dr[0].ToString();
                c.contraseña = dr[1].ToString();
            }
            Cn.Close();
        }
    }
}
