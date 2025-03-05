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
using FormularioDeInicio;

namespace ConsecionarioTecs
{
    public partial class frmNc : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        public frmNc(int t)
        {
            tipo = t;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes frmCliente = Owner as Clientes;
            switch (tipo)
            {
                case 1:
                    // Insertar en la tabla Clientes
                    cadena = "'" + txtNombreC.Text + "','" + txtCompañiaC.Text + "','" +
                             txtTituloC.Text + "','" + txtDireccionC.Text + "','" + txtCiudadC.Text + "','" + txtRegionC.Text + "','" +
                             txtPaisC.Text + "','" + txtTelefonoC.Text + "','" + txtUsuarioC.Text + "','" + txtContraseñaC.Text + "'";

                    conSQL.insertarDatos("Clientes",
                        "NombreCliente,EmpresaCliente,TituloCliente,Dirección,Ciudad,Región,País,Teléfono,LoginUsuario,LoginContraseña",
                        cadena);

                    // Insertar en la tabla Logins con el nombre del cliente
                    string valoresLogin = "'" + txtNombreC.Text + "','" + txtUsuarioC.Text + "','" + txtContraseñaC.Text + "','Usuario'";
                    conSQL.insertarDatos("Logins", "Nombre,Usuario,Password,Tipo_usuario", valoresLogin);
                    break;

                case 2:
                    // Actualizar datos en la tabla Clientes
                    cadena = "NombreCliente='" + txtNombreC.Text +
                             "', EmpresaCliente='" + txtCompañiaC.Text +
                             "', TituloCliente='" + txtTituloC.Text +
                             "', Dirección='" + txtDireccionC.Text +
                             "', Ciudad='" + txtCiudadC.Text +
                             "', Región='" + txtRegionC.Text +
                             "', País='" + txtPaisC.Text +
                             "', Teléfono='" + txtTelefonoC.Text +
                             "', LoginUsuario='" + txtUsuarioC.Text +
                             "', LoginContraseña='" + txtContraseñaC.Text + "'";

                    conSQL.actualizarDatos("Clientes", cadena, "ClienteID='" + txtIDc.Text + "'");

                    // También actualizar la contraseña en la tabla Logins si cambió
                    string valoresActualizarLogin = "Password='" + txtContraseñaC.Text + "'";
                    conSQL.actualizarDatos("Logins", valoresActualizarLogin, "Usuario='" + txtUsuarioC.Text + "'");
                    break;
            }

            frmCliente.dtgvContenedorClientes.DataSource = conSQL.retornaRegistros("SELECT * FROM Clientes");
            this.Close();


            //Clientes frmCs = Owner as Clientes;
            //cadena = "'" + txtNombreC.Text + "','" + txtCompañiaC.Text + "','" + txtTituloC.Text + "','" + txtDireccionC.Text + "','" + txtCiudadC.Text + "','" + txtRegionC.Text + "','" + txtPaisC.Text + "','" + txtTelefonoC.Text + "','" + txtUsuarioC.Text + "','" + txtContraseñaC.Text + "'";
            //ConexionClientes.insertarDatos("Clientes", "[Nombre Cliente],[Empresa Cliente],[Titulo Cliente],Dirección,Ciudad,Región,País,Teléfono,[Login Usuario],[Login Contraseña]", cadena);
            //frmCs.dtgvContenedorClientes.DataSource = ConexionClientes.retornaRegistros("Select * from Clientes");
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAggC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelModificarC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
