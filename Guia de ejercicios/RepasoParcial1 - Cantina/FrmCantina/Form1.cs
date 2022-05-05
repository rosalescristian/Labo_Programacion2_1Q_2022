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
using ControlCantina;
using ControlesUsuario;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10);
            cBoxBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void cBoxBotella_SelectedIndexChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
        }
    }
}
