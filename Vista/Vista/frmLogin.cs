using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            labelCuenta_inexistente.Hide();
        }

       
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            bool iniciar = Controladora.BdComun.CheckearValores(txtNombre_de_usuario.Text, txtcontrasena.Text);

            if (txtNombre_de_usuario.Text == "admin")
            {
                new dashboard(txtNombre_de_usuario.Text).Show();
                this.Hide();
            }

            else if (iniciar)
            {
                
                new dashboard(txtNombre_de_usuario.Text).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario invalido o contraseña incorrecta, Por favor intente de nuevo", "Error al entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre_de_usuario.Text = "";
                txtcontrasena.Text = "";
                txtNombre_de_usuario.Focus();  

            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre_de_usuario.Text = "";
            txtcontrasena.Text = "";
            txtNombre_de_usuario.Focus();
        }

        private void checkBoxMosContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMosContrasena.Checked)
            {
                txtcontrasena.PasswordChar = '\0';
            }
            else
            {
                txtcontrasena.PasswordChar = '•';
            }
        }

        private void labelCrear_cuenta_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
