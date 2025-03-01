using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioDeInicio;

namespace ConsecionarioTecs
{
    public partial class frmNc : Form
    {
        Conexion_BDD ConexionClientes = new Conexion_BDD();
        string cadena;
        public frmNc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmNc_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiudadC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegionC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaisC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes frmCs = Owner as Clientes;
            cadena = "'" + txtNombreC.Text + "','" + txtCompañiaC.Text + "','" + txtTituloC.Text + "','" + txtDireccionC.Text + "','" + txtCiudadC.Text + "','" + txtRegionC.Text + "','" + txtPaisC.Text + "','" + txtTelefonoC.Text + "','" + txtUsuarioC.Text + "','" + txtContraseñaC.Text + "'";
            ConexionClientes.insertarDatos("Clientes", "[Nombre Cliente],[Empresa Cliente],[Titulo Cliente],Dirección,Ciudad,Región,País,Teléfono,[Login Usuario],[Login Contraseña]", cadena);
            frmCs.dtgvContendorClientes.DataSource = ConexionClientes.retornaRegistros("Select * from Clientes");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAggC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
