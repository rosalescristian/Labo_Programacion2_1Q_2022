using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtKilometros.Text) || String.IsNullOrEmpty(txtLitros.Text))
                {
                    throw new ParametrosVaciosException();
                }
                try
                {
                    int km = int.Parse(txtKilometros.Text);
                    int lts = int.Parse(txtLitros.Text);
                    try
                    {
                        int conversion = Calculador.Calcular(km, lts);
                        if (conversion == int.MinValue)
                        {
                            throw new DivideByZeroException();
                        }
                        rtbConversion.Text = $"Valor convertido: {conversion.ToString()}";
                    }
                    catch (DivideByZeroException)
                    {

                        MessageBox.Show("No se puede dividir por CERO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("No se puede convertir este valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(OverflowException)
                {
                    MessageBox.Show("Valor fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ParametrosVaciosException)
            {
                MessageBox.Show("No se pueden dejar los campos de texto vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
