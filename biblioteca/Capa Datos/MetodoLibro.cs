using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Capa_Datos
{
    public class MetodoLibro
    {
        public string idlibro { get; set; }
        public string titulolibro { get; set; }
        public string editorial { get; set; }
        public string pais { get; set; }
        public int año { get; set; }
        public int nPag { get; set; }
        public int existencia { get; set;}
        public int añoInicio { get; set; }
        public int añoFin { get; set; }

    }
}
