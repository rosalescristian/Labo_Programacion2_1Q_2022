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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is not null && lstPacientes.SelectedItem is not null)
            {

                PersonalMedico medico = lstMedicos.SelectedItem as PersonalMedico;
                Paciente paciente = lstPacientes.SelectedItem as Paciente;
                if (paciente is not null && medico is not null)
                {
                    Random random = new Random();
                    paciente.Diagnostico = (Diagnostico)random.Next(0, 3);
                    try
                    {
                        Consulta consulta = medico + paciente;
                        MessageBox.Show($"{consulta.ToString()}");

                    }
                    catch (ArgumentException ex)
                    {

                        MessageBox.Show("no se pudo realizar la consulta");
                    }
                    


                }
            }
            else
            {
                MessageBox.Show("De seleciconar un medico y un paciente");
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is not null)
            {

                rtbInfoMedico.Text = Persona.FichaPersonal(((PersonalMedico) lstMedicos.SelectedItem));
            }
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desesalir","titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
