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

namespace biblioteca.Precentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void nuevo()
        {
            txtAutor.Clear();
            txtIdAutor.Clear();
            txtIdAutor.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar el Autor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoAutor AU = new MetodoAutor();
                AU.idAutor = txtIdAutor.Text;
                AU.nomAutor = txtAutor.Text;
                CLSAutor.ActualizarAutor(AU);

                MessageBox.Show("Autor Actualizo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nuevo();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodoAutor AU = new MetodoAutor();
            AU.idAutor = txtIdAutor.Text;
            try
            {
                CLSAutor.buscarAutor(AU);
            }
            catch (Exception) { MessageBox.Show("Codigo no encontrado" + AU.idAutor); }

            txtAutor.Text = AU.nomAutor;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea grabar el Autor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                MetodoAutor AU = new MetodoAutor();

                AU.idAutor = txtIdAutor.Text;
                AU.nomAutor = txtAutor.Text;

                CLSAutor.InsertarAutor(AU);

                MessageBox.Show("Autor Ingreso Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nuevo();
            }
        }

        private void txtNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
    }
}