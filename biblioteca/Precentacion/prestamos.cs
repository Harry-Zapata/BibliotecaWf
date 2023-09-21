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
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void dtgLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void boorar()
        {
            lbIdLibro.Text = "";
            lbExistencia.Text = "";
            lbLibro.Text = "";
            lbAutor.Text = "";
        }
        void cargarData()
        {
            CLSLibros.listarLibros();
            dtgLibros.DataSource = CLSLibros.ds;
            dtgLibros.DataMember = "Cargar Libros";

            DateTime fecha = DateTime.Now;
            lbFecha.Text = fecha.ToShortDateString();
        }
        private void prestamos_Load(object sender, EventArgs e)
        {
            cargarData();
            lbTotal.Text = dtgVista.RowCount.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MetodoLibro Gl = new MetodoLibro();

            Gl.librosP = txtBuscar.Text;
            CLSLibros.consultarLibrosPrestamos(Gl);
            dtgLibros.DataSource = CLSLibros.ds;
            dtgLibros.DataMember = "Cargar Prestamo";

        }

        private void dtgLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbIdLibro.Text = this.dtgLibros.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbAutor.Text = this.dtgLibros.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbLibro.Text = this.dtgLibros.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbExistencia.Text = this.dtgLibros.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Insertar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                dtgVista.Rows.Add(lbIdLibro.Text, lbLibro.Text, lbAutor.Text, dtpDevolucion.Value.ToString("dd/MM/yyyy"));
                MetodoPrestamo Gl = new MetodoPrestamo();
                Gl.idLibro = lbIdLibro.Text;
                Gl.fechaP = DateTime.Parse(lbFecha.Text);
                Gl.fechaD= DateTime.Parse(dtpDevolucion.Value.ToString("dd/MM/yyyy"));
                Gl.anulado = "No";

                CLSPrestamos.InsertarPrestamo(Gl);

                MetodoLibro G = new MetodoLibro();
                G.idlibro = lbIdLibro.Text;
                G.existencia = int.Parse(lbExistencia.Text)-1;
                CLSLibros.ActualizarLibroExistencia(G);


                MessageBox.Show("Agrego prestamo libro correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTotal.Text = dtgVista.RowCount.ToString(); ;
                cargarData();
                boorar();
                return;

            }
        }

        private void dtgVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbIdLibro.Text = this.dtgLibros.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbAutor.Text = this.dtgLibros.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbLibro.Text = this.dtgLibros.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Quitar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                dtgVista.Rows.RemoveAt(dtgVista.CurrentRow.Index);
                MetodoPrestamo Gl = new MetodoPrestamo();
                Gl.idLibro = lbIdLibro.Text;
                Gl.anulado = "si";

                CLSPrestamos.AnularPrestamos(Gl);

                MetodoLibro G = new MetodoLibro();

                G.idlibro = lbIdLibro.Text;
                try
                {
                    CLSLibros.BuscarLibro(G);
                }
                catch (Exception)
                {
                    MessageBox.Show("Codigo no encontrado");
                }

                string existencia = Convert.ToString(G.existencia);

                G.idlibro = lbIdLibro.Text;
                G.existencia = int.Parse(existencia)+1;
                CLSLibros.ActualizarLibroExistencia(G);

                MessageBox.Show("Quito prestamo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbTotal.Text = dtgVista.RowCount.ToString();
                cargarData();
                return;

            }
        }

        private void btnNewPrestamo_Click(object sender, EventArgs e)
        {
            dtgVista.Rows.Clear();
            lbTotal.Text = dtgVista.RowCount.ToString();
        }
    }
}
