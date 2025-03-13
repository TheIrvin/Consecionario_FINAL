using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class Rechazar_CompraCliente : Form
    {
        public Rechazar_CompraCliente()
        {
            InitializeComponent();
        }
        public TextBox txtNombreC;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public TextBox txtBox_No_aceptado_laVenta;

        private void txtBox_infoNo_aceptadaVenta_TextChanged(object sender, EventArgs e)
        {
            txtBox_No_aceptado_laVenta.Text = txtBox_infoNo_aceptadaVenta.Text;


        }
    }
}
