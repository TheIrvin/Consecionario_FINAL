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
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Productos : Form
    {

        public Productos()
        {
            InitializeComponent();
            LlenarProductos();
        }
        private void LlenarProductos()
        {
            DBMotos obj = new DBMotos();
            obj.llenarBotones(FlpContenedorMotos);

        }

        private void lblxproduct_Click(object sender, EventArgs e)
        {

        }

        private void FlpContenedorMotos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbtnAgregarVentas_Click(object sender, EventArgs e)
        {
            AgregarMoto fmMoto = new AgregarMoto();
            this.AddOwnedForm(fmMoto);
            fmMoto.Show();
        }

        private void tsbtnImprimir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
