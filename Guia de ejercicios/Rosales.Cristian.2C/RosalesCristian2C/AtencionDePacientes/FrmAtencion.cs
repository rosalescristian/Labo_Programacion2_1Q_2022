﻿using System;
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
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
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
            if(lstMedicos.SelectedIndex != -1 && lstPacientes.SelectedIndex != -1)
            {
                PersonalMedico auxPersonalMedico = (PersonalMedico)lstMedicos.SelectedItem;
                Paciente auxPaciente = (Paciente)lstPacientes.SelectedItem;
                Random auxDiagnosticoRandom = new Random();
                int randomDiagnostico = auxDiagnosticoRandom.Next(0, 3);
                auxPaciente.Diagnostico = randomDiagnostico.ToString();
                Consulta auxConsulta = new Consulta(DateTime.Now, auxPaciente);

                if(auxPersonalMedico+auxPaciente)
                {
                    lstMedicos.SelectedIndex = -1;
                    lstPacientes.SelectedIndex = -1;
                    MessageBox.Show($"{auxConsulta.ToString()}", "Atencion Finalizada", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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
