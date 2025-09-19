using System;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double estatura = double.Parse(EstaturaTextBox.Text);
                double masa = double.Parse(MasaTextBox.Text);
                CalculadoraImc miCalcuImc = new CalculadoraImc(estatura, masa);
                string resultado = miCalcuImc.ObtenerDiagnostico();
                DiagnosticoTextBox.Text = resultado;
            }
            catch (FormatException exception)
            {
                MessageBox.Show(
                    "Por favor, los campos masa y estatura deben ser numeros",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
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
