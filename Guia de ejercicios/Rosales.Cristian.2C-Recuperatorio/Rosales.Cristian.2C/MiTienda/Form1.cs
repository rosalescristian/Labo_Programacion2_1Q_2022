using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiTienda
{
    public partial class RosalesCristian : Form
    {
        public RosalesCristian()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearPrenda();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private Prenda CrearPrenda()
        {
            Prenda vacia = new Jean("", Prenda.Talles.Chico, Color.Black, Jean.Calce.Normal);
            if (cmbProducto.SelectedItem is not null && cmbTalle.SelectedItem is not null && txtModelo.Text is not null)
            {
                Prenda prod = (Prenda)cmbProducto.SelectedItem;
                Prenda.Talles talle = (Prenda.Talles)cmbTalle.SelectedItem;
                string modelo = txtModelo.Text.ToString();

                if (prod is Jean)
                {
                    Jean nuevo = new Jean(modelo, talle, Color.Aqua, Jean.Calce.Ajustado);
                    return (Prenda)nuevo;
                }
                if (prod is Camisa)
                {
                    Camisa nueva = new Camisa(modelo, talle, Color.Blue, Color.Gold);
                    return (Prenda)nueva;
                }
            }
            return vacia;
        }

        private void MiTienda_Load(object sender, EventArgs e)
        {

        }

        private void RefrescarListaProductos(RosalesCristian tienda)
        {

        }
    }
}
