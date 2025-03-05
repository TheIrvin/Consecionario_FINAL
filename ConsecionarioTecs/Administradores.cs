using ConsecionarioTecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeInicio
{
    public partial class Administradores : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();

        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnEliminarAdmin_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorAdministradores.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContenedorAdministradores.CurrentRow.Index + ", que pertenece al administrador " + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Administradores", "AdministradorID='" + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
                }
            }
        }

        private void tstxtFiltrarAdmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstxtFiltrarAdmin.Text.Length > 4)
            {
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");
            }

            if (tstxtFiltrarAdmin.Text.Length == 0)
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnFiltrarAdmin_Click(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");

        }

        private void tsbtnAgregarAdmin_Click(object sender, EventArgs e)
        {
            AgregarAdmin nuevoAdmin = new AgregarAdmin(1);
            nuevoAdmin.lblAggAdmin.Visible = true;
            nuevoAdmin.lblModificarAdmin.Visible = false;
            this.AddOwnedForm(nuevoAdmin);
            nuevoAdmin.Show();
        }

        private void tsBtnModificarAdmin_Click(object sender, EventArgs e)
        {
            AgregarAdmin modiAdmin = new AgregarAdmin(2);
            this.AddOwnedForm(modiAdmin);
            modiAdmin.lblAggAdmin.Visible = false;
            modiAdmin.lblModificarAdmin.Visible = true;
            modiAdmin.txtID.Text = dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtNombreAdmin.Text = dtgvContenedorAdministradores[1, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtDireccion.Text = dtgvContenedorAdministradores[2, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCiudad.Text = dtgvContenedorAdministradores[3, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtContacto.Text = dtgvContenedorAdministradores[4, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtRegion.Text = dtgvContenedorAdministradores[5, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtPais.Text = dtgvContenedorAdministradores[6, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtTelefono.Text = dtgvContenedorAdministradores[7, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtCargo.Text = dtgvContenedorAdministradores[8, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtUsuarioAdmin.Text = dtgvContenedorAdministradores[9, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtContraseñaAdmin.Text = dtgvContenedorAdministradores[10, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString();
            modiAdmin.txtID.Enabled = false; //puedo cambiar lo que sea, menos el código y por eso está en false
            modiAdmin.Show();
        }
    }
}
