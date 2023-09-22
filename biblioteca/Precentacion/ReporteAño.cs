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
    public partial class ReporteAño : Form
    {
        public int DatoA = 0;
        public int DatoB = 0;
        public ReporteAño()
        {
            InitializeComponent();
        }

        private void ReporteAño_Load(object sender, EventArgs e)
        {
            ReporteLibroAño reporte = new ReporteLibroAño();
            crystalReportViewer1.ReportSource = reporte;
            reporte.SetParameterValue("@año", this.DatoA);
            reporte.SetParameterValue("@año2", this.DatoB);
            reporte.SetDatabaseLogon("sa", "Senati");
        }
    }
}
