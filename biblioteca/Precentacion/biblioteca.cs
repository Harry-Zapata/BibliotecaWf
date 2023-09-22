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
    public partial class biblioteca : Form
    {
        public biblioteca()
        {
            InitializeComponent();
        }
        void libro()
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        void autor()
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        void prestamoLibro()
        {
            prestamos frm = new prestamos();
            frm.ShowDialog();
        }
        void consultarLibroAutor()
        {
            Consultar consultar = new Consultar();
            consultar.ShowDialog();
        }
        void consultarAño()
        {
            FiltroAños frm = new FiltroAños();
            frm.ShowDialog();
        }
        void consultarFecha()
        {
            prestamoFecha frm = new prestamoFecha();
            frm.ShowDialog();
        }
        void ReporteLibroAutor()
        {
            Reporte frm = new Reporte();
            frm.ShowDialog();
        }
        void ReporteLibroAño()
        {
            RVReporteAño frm = new RVReporteAño();
            frm.ShowDialog();
        }
        private void imgLibro_Click(object sender, EventArgs e)
        {
            libro();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            libro();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libro();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            libro();
        }

        private void imgAutor_Click(object sender, EventArgs e)
        {
            autor();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            autor();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autor();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            autor();
        }

        private void prestamoLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamoLibro();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prestamoLibro();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            prestamoLibro();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            prestamoLibro();
        }

        private void imgConsultarLA_Click(object sender, EventArgs e)
        {
            consultarLibroAutor();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            consultarLibroAutor();
        }

        private void consultarLibrosAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarLibroAutor();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            consultarLibroAutor();
        }

        private void imgConsultarAño_Click(object sender, EventArgs e)
        {
            consultarAño();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            consultarAño();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            consultarAño();
        }

        private void consultraPorAñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarAño();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            consultarFecha();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            consultarFecha();
        }

        private void libroAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteLibroAutor();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReporteLibroAutor();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ReporteLibroAutor();
        }

        private void libroAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteLibroAño();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ReporteLibroAño();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ReporteLibroAño();
        }
    }
}
