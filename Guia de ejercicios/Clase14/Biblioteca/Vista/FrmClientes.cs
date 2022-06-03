using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtDireccion.Text);
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Guardar(cliente);

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            lstClientes.DataSource = clienteDAO.Leer();
        }
    }
}
