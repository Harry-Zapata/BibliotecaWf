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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biblioteca.Precentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MetodoUsuario US = new MetodoUsuario();

            US.usuario = txtUsuario.Text;
            US.contraseña = txtContraseña.Text;

            if ((txtUsuario.Text != "") && (txtContraseña.Text!=""))
            {
                try
                {
                    CLSUsuario.Login(US);
                    biblioteca frm = new biblioteca();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                    
                }
                catch (Exception) { MessageBox.Show("Verificar Usuario o contraseña"); }
            }
            else
            {
                MessageBox.Show("Deve Rellenar los campos");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = ' ';
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }
    }
}
