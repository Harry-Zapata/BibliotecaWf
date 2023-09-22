using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca.Precentacion
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            ReporteLibrosAutor reporte = new ReporteLibrosAutor();
            CRview.ReportSource = reporte;
            reporte.SetDatabaseLogon("sa", "Senati");
            reporte.Refresh();
        }

        private void CRview_Load(object sender, EventArgs e)
        {

        }
    }
}
