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
    public partial class notif_Clientes_Compra : Form
    {
        public notif_Clientes_Compra()
        {
            InitializeComponent();
        }

        private void bt_evaluarMoto_ntf_clt_Click(object sender, EventArgs e)
        {
            pnl_Monstrar_btn_Evaluar.Visible = true;
            AbrirEnPanel(new Evaluar_compraCliente());
        }
        public Label lbl_para_Cliente_rchCmp;
        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            lbl_para_Cliente_rchCmp.Text = txtNombreC.Text;
        }
        
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnl_Monstrar_btn_Evaluar.Controls.Count > 0)
            {
                this.pnl_Monstrar_btn_Evaluar.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnl_Monstrar_btn_Evaluar.Controls.Add(fn);
                this.pnl_Monstrar_btn_Evaluar.Tag = fn;
                fn.Show();
            }
        }
    }
}
