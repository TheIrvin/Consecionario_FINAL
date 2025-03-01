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
            dtgvContendorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void dtgvContendorClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
