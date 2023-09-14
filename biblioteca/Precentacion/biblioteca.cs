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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void consultarLibrosAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar cst = new Consultar();
            cst.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Consultar cst = new Consultar();
            cst.ShowDialog();
        }

        private void biblioteca_Load(object sender, EventArgs e)
        {

        }

        private void consultraPorAñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroAños fa = new FiltroAños();
            fa.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FiltroAños fa = new FiltroAños();
            fa.ShowDialog();
        }
    }
}
