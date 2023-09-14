using biblioteca.Capa_Datos;
using biblioteca.Capa_Logica;
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
    public partial class FiltroAños : Form
    {

        public FiltroAños()
        {
            InitializeComponent();
        }
        public void CargarData()
        {
            CLSLibros.listarLibros();
            dtgAño.DataSource = CLSLibros.ds;
            dtgAño.DataMember = "Cargar Libros";
        }

        private void FiltroAños_Load(object sender, EventArgs e)
        {
           CargarData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if ((txtAñoInicio.Text != "") && (txtAñoFin.Text != ""))
            {
                if (int.Parse(txtAñoInicio.Text) <= int.Parse(txtAñoFin.Text))
                {
                    try
                    {
                        MetodoLibro Gl = new MetodoLibro();
                        Gl.añoInicio = int.Parse(txtAñoInicio.Text);
                        Gl.añoFin = int.Parse(txtAñoFin.Text);
                        CLSLibros.consultarLibrosAño(Gl);
                        dtgAño.DataSource = CLSLibros.ds;
                        dtgAño.DataMember = "Cargar Año";
                    }
                    catch (Exception) { MessageBox.Show("error"); }
                }
                else
                {
                    MessageBox.Show("El campo de de inicio tiene que ser mayor al campo de fin");
                }
            }
            else
            {
                MessageBox.Show("Deve Rellenar los campos");
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarData();
            txtAñoInicio.Clear();
            txtAñoFin.Clear();
            txtAñoInicio.Focus();
        }
    }
}
