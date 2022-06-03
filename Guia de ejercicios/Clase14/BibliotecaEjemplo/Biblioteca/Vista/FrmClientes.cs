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
        ClienteDAO clienteDAO;
        public FrmClientes()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(txtNombre.Text, txtDireccion.Text);



                clienteDAO.Guardar(cliente);
                this.ActualizarLstClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            lstClientes.DataSource = clienteDAO.Leer();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDireccion.Text))
            {
                Cliente nuevoCliente = new Cliente(txtNombre.Text, txtDireccion.Text);

                Cliente clienteSeleccionado = lstClientes.SelectedItem as Cliente;

                if (clienteSeleccionado is not null)
                {

                    clienteDAO.Modificar(clienteSeleccionado.Id, nuevoCliente);
                }
                this.ActualizarLstClientes();
            }
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            Cliente? cliente = lstClientes.SelectedItem as Cliente;
            if (cliente is not null)
            {
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = lstClientes.SelectedItem as Cliente;
            if (clienteSeleccionado is not null)
            {

                clienteDAO.Eliminar(clienteSeleccionado.Id);
            }
            this.ActualizarLstClientes();
        }

        private void ActualizarLstClientes()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = clienteDAO.Leer();
        }
    }
}
