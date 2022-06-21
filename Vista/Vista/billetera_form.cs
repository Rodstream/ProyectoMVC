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
        public billetera_form()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            valor_box.SelectedIndex = 0;
        }

        private void valor_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new dashboard().Show(); Error
            this.Close();

        }
    }
}
