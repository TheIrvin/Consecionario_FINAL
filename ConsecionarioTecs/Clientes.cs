using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Clientes : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        //int bandera = 0;
        //int clientexPag = 40;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorClientes.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContenedorClientes.CurrentRow.Index + ", que pertenece al administrador " + dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Clientes", "ClienteID='" + dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
                }
            }
        }

        private void tstxtFiltrarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstxtFiltrarCliente.Text.Length > 4)
            {
                dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ClienteID like '%" + tstxtFiltrarCliente.Text + "%' or NombreCliente like '%" + tstxtFiltrarCliente.Text + "%'");
            }

            if (tstxtFiltrarCliente.Text.Length == 0)
                dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbtnFiltrarCliente_Click(object sender, EventArgs e)
        {
            dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ClienteID like '%" + tstxtFiltrarCliente.Text + "%' or NombreCliente like '%" + tstxtFiltrarCliente.Text + "%'");
        }

        private void tsbtnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmNc nuevoCliente = new frmNc(1);
            nuevoCliente.lblAgregarClientes.Visible = true;
            nuevoCliente.lblModificarCliente.Visible = false;
            this.AddOwnedForm(nuevoCliente);
            nuevoCliente.Show();
        }

        private void tsBtnModificarCliente_Click(object sender, EventArgs e)
        {
            frmNc modiAdmin = new frmNc(2);
            this.AddOwnedForm(modiAdmin);
            modiAdmin.lblAgregarClientes.Visible = false;
            modiAdmin.lblModificarCliente.Visible = true;
            modiAdmin.txtIDc.Text = dtgvContenedorClientes[0, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtNombreC.Text = dtgvContenedorClientes[1, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCompañiaC.Text = dtgvContenedorClientes[2, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtTituloC.Text = dtgvContenedorClientes[3, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtDireccionC.Text = dtgvContenedorClientes[4, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCiudadC.Text = dtgvContenedorClientes[5, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtRegionC.Text = dtgvContenedorClientes[6, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtPaisC.Text = dtgvContenedorClientes[7, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtTelefonoC.Text = dtgvContenedorClientes[8, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtUsuarioC.Text = dtgvContenedorClientes[9, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtContraseñaC.Text = dtgvContenedorClientes[10, dtgvContenedorClientes.CurrentRow.Index].Value.ToString();
            modiAdmin.txtIDc.Enabled = false; //puedo cambiar lo que sea, menos el código y por eso está en false
            modiAdmin.Show();
        }
    }
}
