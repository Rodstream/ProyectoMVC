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

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre_de_usuario.Text == "" && txtContrasena.Text == "" && txtConcontrasena.Text == "")
            {
                MessageBox.Show("Faltan completar datos", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContrasena.Text == txtConcontrasena.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtNombre_de_usuario.Text + "','" + txtContrasena.Text + "')";
                cmd = new OleDbCommand(register);
                cmd.ExecuteNonQuery();
                con.Close();

                txtNombre_de_usuario.Text = "";
                txtContrasena.Text = "";
                txtConcontrasena.Text = "";

                MessageBox.Show("Tu cuenta ha sido creada", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContrasena.Text = "";
                txtConcontrasena.Text = "";
                txtContrasena.Focus();
            }

        }

        private void checkBoxMosContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMosContrasena.Checked)
            {
                txtContrasena.PasswordChar = '\0';
                txtConcontrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '•';
                txtConcontrasena.PasswordChar = '•';
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre_de_usuario.Text = "";
            txtContrasena.Text = "";
            txtConcontrasena.Text = "";
            txtNombre_de_usuario.Focus();
        }

        private void labelVolver_log_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
