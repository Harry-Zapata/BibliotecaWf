using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Capa_Datos
{
    public class CLSConexion
    {
        public static String cnCadena()
        {
            String Str = "SERVER=14ET202-PC24;DataBase=biblioteca;UID=sa;PWD=Senati";
            return Str;
        }
    }
}
