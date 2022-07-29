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
    public partial class dashboard : Form
    {
        public dashboard(string user) //a
        {
            InitializeComponent();
            Size = new Size(1662, 1091);
            compra_lbl.Text = compra.ToString();
            user_lbl.Text = user;
            actual_lbl.Text = Controladora.BdComun.ObtenerCuenta(user_lbl.Text);

        }

        int compra = 0;
        int cantidad = 0;
        string juegos = "";

        private void Carrito_panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();

        }

        private void Carrito_panel_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void carrito_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carrito_scroll_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            compra += 1800;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Cyberpunk 2077\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            compra += 10800;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Zelda: Breath Of The Wild\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            compra += 10800;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Super Mario Galaxy 2\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            compra += 1800;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Uncharted 4: A Thieve's End\n";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            compra += 3500;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Minecraft\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            compra += 1500;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Rainbow Six\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compra += 10800;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Spider Man\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compra += 9000;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- Forza Horizon 5\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compra += 3600;
            compra_lbl.Text = compra.ToString();
            cantidad += 1;
            productos_lbl.Text = cantidad.ToString();
            juegos += "- God Of War\n";

        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            compra = 0;
            compra_lbl.Text = compra.ToString();
            cantidad = 0;
            productos_lbl.Text = cantidad.ToString();
            juegos = "";
        }

        private void compra_btn_Click(object sender, EventArgs e)
        {
            int aux_actual = Int32.Parse(actual_lbl.Text);
            int aux_compra = Int32.Parse(compra_lbl.Text);
            if (juegos != "" && aux_actual > aux_compra)
            {
                Factura factura_pantalla = new Factura(juegos, compra, user_lbl.Text);
                this.Close();

                factura_pantalla.Show();

            }
            else
            {
                MessageBox.Show("Selecciona algun juego o verifique que cuenta con el dinero necesario para la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void billetera_btn_Click(object sender, EventArgs e)
        {
            billetera_form billetera = new billetera_form(user_lbl.Text);
            billetera.Show();
            this.Close();
            actual_lbl.Text = Controladora.BdComun.ObtenerCuenta(user_lbl.Text);



        }

        private void actual_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminar_user_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Confirme si desea eliminar el usuario", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Controladora.BdComun.Eliminar(user_lbl.Text);
                this.Close();
            }
        }
    }
}
