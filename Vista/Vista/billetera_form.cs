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
    public partial class billetera_form : Form
    {
        public billetera_form(string user)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            valor_box.SelectedIndex = 0;
            user_lbl.Text = user;
        }

        private void valor_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor_cuenta = "0";
            string cuenta_actual = Controladora.BdComun.ObtenerCuenta(user_lbl.Text);
            int aux_valor = Int32.Parse(valor_cuenta);
            int aux_cuenta = Int32.Parse(cuenta_actual);
            if (valor_box.SelectedIndex == 0)
            {
                valor_cuenta = (aux_cuenta + 1000).ToString();
            }
            else if (valor_box.SelectedIndex == 1)
            {
                valor_cuenta = (aux_cuenta + 5000).ToString();
            }
            else if (valor_box.SelectedIndex == 2)
            {
                valor_cuenta = (aux_cuenta + 10000).ToString();
            }
            Controladora.BdComun.UpdateCuenta(user_lbl.Text, valor_cuenta);
            new dashboard(user_lbl.Text).Show();

            this.Close();

        }
    }
}
