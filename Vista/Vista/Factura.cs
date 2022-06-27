using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Factura : Form
    {
        public Factura(string juegos, int valor, string user)
        {
            InitializeComponent();

            lblpreciofinal.Text = valor.ToString();
            lbl_juegos.Text = juegos;
            user_lbl.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuenta_actual = Controladora.BdComun.ObtenerCuenta(user_lbl.Text);
            int aux_valor = Int32.Parse(cuenta_actual);
            int valor_compra = Int32.Parse(lblpreciofinal.Text);
            string comando = (aux_valor - valor_compra).ToString();
            Controladora.BdComun.UpdateCuenta(user_lbl.Text, comando);
            new dashboard(user_lbl.Text).Show();
            this.Close();
        }
    }
}
