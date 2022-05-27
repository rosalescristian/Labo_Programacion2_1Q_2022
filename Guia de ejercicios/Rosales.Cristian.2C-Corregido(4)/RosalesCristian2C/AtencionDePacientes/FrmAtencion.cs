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

namespace AtencionDePacientes
{
    public partial class FrmAtencion : Form
    {
        public enum DiagnosticoRandom
        {
            Curado, Gripe, Coronavirus
        }
        /// <summary>
        /// Inicializa el Form
        /// </summary>
        public FrmAtencion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }

        /// <summary>
        /// Click del Boton Atender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if(lstMedicos.SelectedIndex != -1 && lstPacientes.SelectedIndex != -1)
            {
                Random auxDiagnosticoRandom = new Random();
                int randomDiagnostico = auxDiagnosticoRandom.Next(0, 3);
                PersonalMedico auxPersonalMedico = (PersonalMedico)lstMedicos.SelectedItem;
                Paciente auxPaciente = (Paciente)lstPacientes.SelectedItem;
                DiagnosticoRandom diagnostico = (DiagnosticoRandom)randomDiagnostico;
                auxPaciente.Diagnostico = diagnostico.ToString();

                if(auxPersonalMedico+auxPaciente)
                {
                    lstMedicos.SelectedIndex = -1;
                    lstPacientes.SelectedIndex = -1;
                    Consulta auxConsulta = new Consulta(DateTime.Now, auxPaciente);

                    MessageBox.Show($"{auxConsulta.ToString()}", "Atencion Finalizada", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        /// <summary>
        /// Click del Boton Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Form Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cambio de Index en la lista de Medicos (lstMedicos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMedicos.SelectedIndex != -1)
            {
                PersonalMedico auxPersonalMedico = (PersonalMedico)lstMedicos.SelectedItem;
                Persona auxPersona = (Persona)auxPersonalMedico;
                rtbInfoMedico.Text = auxPersonalMedico.FichaPersonal(auxPersonalMedico);
            }
        }
    }
}
