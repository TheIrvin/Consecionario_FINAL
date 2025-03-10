using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class Compra_Proveedor: Form
    {
        public Compra_Proveedor()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; //tipo=1 entonces inserto datos, tipo=2 entonces modificar datos
        public Compra_Proveedor(int t)
        {
            tipo = t;
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_compra_Proveedor_Click(object sender, EventArgs e)
        {
            Gestionar_Proveedores_DGV frm_gestProveedor = Owner as Gestionar_Proveedores_DGV;

            switch (tipo)
            {
                case 1: // Insertar nueva compra
                    cadena = "'" + txtBox_PVD_idCompra.Text + "','" + txtBox_PVD_nombreEmpresa.Text + "','" + txtBox_PVD_RUC.Text + "','" +
                             txtBox_PVD_dirección.Text + "','" + txtBox_PVD_contacto.Text + "','" + txtBox_PVD_Email.Text + "','" +
                             txtBox_PVD_teléfono.Text + "','" + txtBox_PVD_modeloMoto.Text + "','" + txtBox_PVD_marcaMoto.Text + "','" +
                             txtBox_PVD_añoMoto.Text + "'," + txtBox_PVD_precioMoto.Text + "," + txtBox_PVD_totalMotos.Text;

                    conSQL.insertarDatos("Compra_Motos_Proveedores",
                        "ID_Compra, Nombre_Empresa, RUC_Empresa, Direccion, Nombre_Contacto, Email, Telefono, " +
                        "Modelo_Moto, Marca_Moto, Año_Moto, Precio_Moto, Total_Motos",
                        cadena);
                    break;

                case 2: // Actualizar una compra existente
                    cadena = "Nombre_Empresa='" + txtBox_PVD_nombreEmpresa.Text + "', RUC_Empresa='" + txtBox_PVD_RUC.Text +
                             "', Direccion='" + txtBox_PVD_dirección.Text + "', Nombre_Contacto='" + txtBox_PVD_contacto.Text +
                             "', Email='" + txtBox_PVD_Email.Text + "', Telefono='" + txtBox_PVD_teléfono.Text +
                             "', Modelo_Moto='" + txtBox_PVD_modeloMoto.Text + "', Marca_Moto='" + txtBox_PVD_marcaMoto.Text +
                             "', Año_Moto='" + txtBox_PVD_añoMoto.Text + "', Precio_Moto=" + txtBox_PVD_precioMoto.Text +
                             ", Total_Motos=" + txtBox_PVD_totalMotos.Text;

                    conSQL.actualizarDatos("Compra_Motos_Proveedores", cadena, "ID_Compra='" + txtBox_PVD_idCompra.Text + "'");
                    break;
            }

            frm_gestProveedor.dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Compra_Motos_Proveedores");
            this.Close();

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Compra_Proveedor_Load(object sender, EventArgs e)
        {
            txtBox_PVD_idCompra.BringToFront();
            txtBox_PVD_nombreEmpresa.BringToFront();
            txtBox_PVD_RUC.BringToFront();
            txtBox_PVD_dirección.BringToFront();
            txtBox_PVD_contacto.BringToFront();
            txtBox_PVD_Email.BringToFront();
            txtBox_PVD_teléfono.BringToFront();
            txtBox_PVD_modeloMoto.BringToFront();
            txtBox_PVD_marcaMoto.BringToFront();
            txtBox_PVD_añoMoto.BringToFront();
            txtBox_PVD_precioMoto.BringToFront();
            txtBox_PVD_totalMotos.BringToFront();
        }

        private void txtBox_PVD_RUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_PVD_dirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        
    }
}
