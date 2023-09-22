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
    public partial class RVReporteAño : Form
    {
        public RVReporteAño()
        {
            InitializeComponent();
        }

        private void RVReporteAño_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteAño frm = new ReporteAño();
            frm.DatoA=int.Parse(this.txtInicio.Text);
            frm.DatoB = int.Parse(this.txtFin.Text);
            frm.ShowDialog();
        }
    }
}
