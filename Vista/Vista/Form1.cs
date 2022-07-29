﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Chequeando datos ingresados por pantalla
            if (txtNombre_de_usuario.Text == "" && txtContrasena.Text == "" && txtConcontrasena.Text == "")
            {
                MessageBox.Show("Faltan completar datos", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Si las claves son iguales, procedemos al registro
            else if (txtContrasena.Text == txtConcontrasena.Text)
            {

                string user = txtNombre_de_usuario.Text;
                string password = Controladora.BdComun.Encriptar(txtContrasena.Text);
                
                txtNombre_de_usuario.Text = "";
                txtContrasena.Text = "";
                txtConcontrasena.Text = "";
                Controladora.BdComun.InsertarValores(user, password);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContrasena.Text = "";
                txtConcontrasena.Text = "";
                txtContrasena.Focus();
            }

        }

        // Funcion para hacer visible la contrasena
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

        // Cambiamos al formulario de inicio de sesion
        private void labelVolver_log_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
