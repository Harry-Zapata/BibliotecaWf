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
using biblioteca.Capa_Datos;


namespace biblioteca.Precentacion
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cbElegir.Items.Add("Titulo");
            cbElegir.Items.Add("Pais");
            cbElegir.Items.Add("Editorial");

            CLSLibros.listarLibros();
            DtgLibro.DataSource = CLSLibros.ds;
            DtgLibro.DataMember = "Cargar Libros";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodoLibro Gl = new MetodoLibro();
            
            if (cbElegir.SelectedIndex == 0)
            {
                Gl.titulolibro = txtTexto.Text;
                CLSLibros.consultarLibrosTitulos(Gl);
                DtgLibro.DataSource = CLSLibros.ds;
                DtgLibro.DataMember = "Cargar titulos";
            }
            if (cbElegir.SelectedIndex == 1)
            {
                Gl.pais = txtTexto.Text;
                CLSLibros.consultarLibrosPais(Gl);
                DtgLibro.DataSource = CLSLibros.ds;
                DtgLibro.DataMember = "Cargar Paises";
            }
            if (cbElegir.SelectedIndex == 2)
            {
                Gl.editorial = txtTexto.Text;
                CLSLibros.consultarLibrosEditorial(Gl);
                DtgLibro.DataSource = CLSLibros.ds;
                DtgLibro.DataMember = "Cargar Editorial";
            }

        }

        private void DtgLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
