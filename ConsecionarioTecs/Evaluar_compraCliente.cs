using FormularioDeInicio;
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
    public partial class Evaluar_compraCliente : Form
    {
        public Button btnVentaRechazada;
        private VistaCliente vistaCl;

        public Evaluar_compraCliente()
        {
            InitializeComponent();
        }
        public Evaluar_compraCliente(VistaCliente vistaC)  // Constructor que recibe Form2
        {
            InitializeComponent();
            vistaCl = vistaC; // Guardamos la instancia
        }

        private void chkBox_klmt_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }

        private void chkBox_motorMoto_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }

        private void chkBox_sinMultas_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }

        private void chkBox_sinFugas_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }

        private void chkBox_noReportada_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }

        private void chkBox_enRegla_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheckBoxes();
        }
        private void VerificarCheckBoxes()
        {
            bool todoMarcado =
            chkBox_klmt.Checked &&  
            chkBox_motorMoto.Checked &&
            chkBox_sinMultas.Checked &&
            chkBox_sinFugas.Checked &&
            chkBox_noReportada.Checked &&
            chkBox_enRegla.Checked;

            chkBox_todo_en_ORDEN.Enabled = todoMarcado;

        }
        private void btn_rechazarCompra_a_Cliente_Click(object sender, EventArgs e)
        {
            btnVentaRechazada.Visible = true;
            btnVentaRechazada.Enabled = true;

            Rechazar_CompraCliente rechazado = new Rechazar_CompraCliente();

        }

        private void btn_ComprarMoto_a_Cliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro");
        }

        private void pnl_evaluarCompra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBox_todo_en_ORDEN_CheckedChanged(object sender, EventArgs e)
        {
            btn_ComprarMoto_a_Cliente.Enabled = chkBox_todo_en_ORDEN.Checked;

        }
    }
}
