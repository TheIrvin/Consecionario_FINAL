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
    public partial class AgregarAdmin : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        public AgregarAdmin(int t)
        {
            tipo = t;
            InitializeComponent();
        }

        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            Administradores frmAdmin = Owner as Administradores;
            switch (tipo)
            {
                case 1:
                    cadena = "'" + txtID.Text + "','" + txtNombreAdmin.Text + "','" + txtDireccion.Text + "','" + txtCiudad.Text + "','" + txtContacto.Text + "','" + txtRegion.Text + "','" + txtPais.Text + "','" + txtTelefono.Text + "','" + txtCargo.Text + "','" + txtUsuario.Text + "','" + txtContraseña.Text + "'";
                    conSQL.insertarDatos("Administradores", "AdministradorID,NombreAdmin,Direccion,Ciudad,Contacto,Region,Pais,Telefono,Cargo,Usuario,Contraseña", cadena);
                    break;
                case 2:
                    cadena = "NombreAdmin='" + txtNombreAdmin.Text + "', Direccion='" + txtDireccion.Text +
                        "', Ciudad='" + txtCiudad.Text + "', Contacto='" + txtContacto.Text +
                        "', Region='" + txtCiudad.Text + "', Pais='" + txtPais.Text +
                        "', Telefono='" + txtTelefono.Text + "', Cargo='" + txtCargo.Text +
                        "', Usuario='" + txtTelefono.Text + "', Contraseña='" + txtContraseña.Text + "'";
                    conSQL.actualizarDatos("Customers", cadena, "AdministradorID='" + txtID.Text + "'");
                    break;
            }
            frmAdmin.dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Customers");
            this.Close();
        }

        private void btnCancelarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
