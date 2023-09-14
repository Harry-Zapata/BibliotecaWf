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
using biblioteca.Capa_Logica;
using biblioteca.Precentacion;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void nuevo() 
        {
            txtId.Clear();
            txtEditorial.Clear();
            txtExistencia.Clear();
            txtAño.Clear();
            txtTitulo.Clear();
            txtPais.Clear();
            txtPag.Clear();
            cbsAutor.Text = "Seleccionar";
            txtId.Focus();
        }
        private void LlenarAutores()
        {
            CLSAutor.LLenarCombox();
            cbsAutor.DataSource = CLSAutor.dt;
            cbsAutor.DisplayMember = "nomAutor";
            cbsAutor.ValueMember = "idAutor";
            cbsAutor.Text = "Seleccionar";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarAutores();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea grabar los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoLibro Cl = new MetodoLibro();
                Cl.idlibro = txtId.Text;
                Cl.titulolibro = txtTitulo.Text;
                Cl.editorial = txtEditorial.Text;
                Cl.pais = txtPais.Text;
                Cl.año = int.Parse(txtAño.Text);
                Cl.nPag = int.Parse(txtPag.Text);
                Cl.existencia = int.Parse(txtExistencia.Text);
                CLSLibros.InsertarLibro(Cl);

                Metodo_Libro_Autor GA = new Metodo_Libro_Autor();
                GA.idLibro = txtId.Text;
                GA.idAutor = cbsAutor.SelectedValue.ToString();
                CLSLibros_Autor.InsertarLibrosAutor(GA);

                MessageBox.Show("Libros Ingreso Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nuevo();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cbsAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MetodoLibro Gl = new MetodoLibro();

            Gl.idlibro = txtId.Text;
                try
                {
                    CLSLibros.BuscarLibro(Gl);
                }
                catch (Exception) { MessageBox.Show("Codigo no encontrado"+ Gl.idlibro); }
            txtTitulo.Text = Gl.titulolibro;
            txtEditorial.Text = Gl.editorial;
            txtPais.Text = Gl.pais;
            txtAño.Text = Convert.ToString(Gl.año);
            txtPag.Text = Convert.ToString(Gl.nPag);
            txtExistencia.Text = Convert.ToString(Gl.existencia);

            Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
            Ga.idLibro = txtId.Text;
            try
            {
                CLSLibros_Autor.BuscarLibrosAutor(Ga);
            }
            catch (Exception) { 
                MessageBox.Show("Codigo no encontrado"+Ga.nomAutor);
                //nuevo();
            }
            cbsAutor.Text = Ga.nomAutor;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoLibro Cl = new MetodoLibro();
                Cl.idlibro = txtId.Text;
                Cl.titulolibro = txtTitulo.Text;
                Cl.editorial = txtEditorial.Text;
                Cl.pais = txtPais.Text;
                Cl.año = int.Parse(txtAño.Text);
                Cl.nPag = int.Parse(txtPag.Text);
                Cl.existencia = int.Parse(txtExistencia.Text);
                CLSLibros.ActualizarLibro(Cl);

                Metodo_Libro_Autor GA = new Metodo_Libro_Autor();
                GA.idLibro = txtId.Text;
                GA.idAutor = cbsAutor.SelectedValue.ToString();
                CLSLibros_Autor.ActualizarLibrosAutor(GA);

                MessageBox.Show("Libros Actualizo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nuevo();
            }
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            Form2 frm  = new Form2();
            frm.ShowDialog();
        }

        private void cbsAutor_Click(object sender, EventArgs e)
        {
            LlenarAutores();
        }
    }
    }