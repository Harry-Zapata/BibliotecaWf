using biblioteca.Capa_Datos;
using biblioteca.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca.Precentacion
{
    public partial class prestamoFecha : Form
    {
        public prestamoFecha()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prestamoFecha_Load(object sender, EventArgs e)
        {
            CLSPrestamos.listarPrestadosSinAnular();
            dtgPestamo.DataSource = CLSPrestamos.ds;
            dtgPestamo.DataMember = "Cargar prestamo sin anular";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtInicio.Value<dtFin.Value)
            {
                if (cbTipo.Text == "Fecha_inicio")
                {
                    try
                    {
                        MetodoPrestamo Gl = new MetodoPrestamo();
                        Gl.fechaP = DateTime.Parse(dtInicio.Value.ToString("dd/MM/yyyy"));
                        Gl.fechaD = DateTime.Parse(dtFin.Value.ToString("dd/MM/yyyy"));
                        CLSPrestamos.BuscarPorInicio(Gl);
                        dtgPestamo.DataSource = CLSPrestamos.ds;
                        dtgPestamo.DataMember = "Cargar Inicio";
                    }
                    catch (Exception) { MessageBox.Show("error"); }
                }
                else if (cbTipo.Text == "Fecha_fin")
                {
                    try
                    {
                        MetodoPrestamo Gl = new MetodoPrestamo();
                        Gl.fechaP = DateTime.Parse(dtInicio.Value.ToString("dd/MM/yyyy"));
                        Gl.fechaD = DateTime.Parse(dtFin.Value.ToString("dd/MM/yyyy"));
                        CLSPrestamos.BuscarPorFin(Gl);
                        dtgPestamo.DataSource = CLSPrestamos.ds;
                        dtgPestamo.DataMember = "Cargar Fin";
                    }
                    catch (Exception) { MessageBox.Show("error"); }
                }
                else
                {
                    MessageBox.Show("Seleccione el filtro");
                }
            }
            else
            {
                MessageBox.Show("El campo de de inicio tiene que ser mayor al campo de fin");
            }
            
        }
    }
}
