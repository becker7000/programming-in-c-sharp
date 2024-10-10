using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores de los TextBoxes
                double masa = double.Parse(MasaTextBox.Text);
                double estatura = double.Parse(EstaturaTextBox.Text);

                // Crear instancia de DiagnosticadorImc
                DiagnosticadorImc diagnosticador = new DiagnosticadorImc(masa, estatura);

                // Obtener el diagnóstico
                string resultado = diagnosticador.ObtenerDiagnostico();

                // Mostrar el resultado en el TextBox de diagnóstico
                DiagnosticoTextBox.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para masa y estatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            MasaTextBox.Text = "";
            EstaturaTextBox.Text = "";
            DiagnosticoTextBox.Text = "";
        }
    }
}
