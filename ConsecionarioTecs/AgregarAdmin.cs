using FormularioDeInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            Administradores frmAdmin = Owner as Administradores;
            switch (tipo)
            {
                case 1:
                    cadena = "'" + txtNombreAdmin.Text + "','" + txtDireccion.Text + "','" +
                             txtCiudad.Text + "','" + txtContacto.Text + "','" + txtRegion.Text + "','" + txtPais.Text + "','" +
                             txtTelefono.Text + "','" + txtCargo.Text + "','" + txtUsuarioAdmin.Text + "','" + txtContraseñaAdmin.Text + "'";

                    conSQL.insertarDatos("Administradores",                                  "NombreAdmin,Direccion,Ciudad,Contacto,Region,Pais,Telefono,Cargo,UsuarioAdmin,ContraseñaAdmin",
                        cadena);

                    string valoresLogin = "'" + txtNombreAdmin.Text + "','" + txtUsuarioAdmin.Text + "','" + txtContraseñaAdmin.Text + "','Administrador'";
                    conSQL.insertarDatos("Logins", "Nombre,Usuario,Password,Tipo_usuario", valoresLogin);
                    break;

                case 2:
                    cadena = "NombreAdmin='" + txtNombreAdmin.Text +
                             "', Direccion='" + txtDireccion.Text +
                             "', Ciudad='" + txtCiudad.Text +
                             "', Contacto='" + txtContacto.Text +
                             "', Region='" + txtRegion.Text +
                             "', Pais='" + txtPais.Text +
                             "', Telefono='" + txtTelefono.Text +
                             "', Cargo='" + txtCargo.Text +
                             "', UsuarioAdmin='" + txtUsuarioAdmin.Text +
                             "', ContraseñaAdmin='" + txtContraseñaAdmin.Text + "'";

                    conSQL.actualizarDatos("Administradores", cadena, "AdministradorID='" + txtID.Text + "'");

                    string valoresActualizarLogin = "Password='" + txtContraseñaAdmin.Text + "'";
                    conSQL.actualizarDatos("Logins", valoresActualizarLogin, "Usuario='" + txtUsuarioAdmin.Text + "'");
                    break;
            }

            frmAdmin.dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("SELECT * FROM Administradores");
            this.Close();
        }

        private void btnCancelarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelAggAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
