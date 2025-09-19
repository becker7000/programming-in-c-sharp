using System;

namespace CalculadoraIMC
{
    public class CalculadoraImc
    {
        private double estatura;
        private double masa;
        private double imc;

        public CalculadoraImc(double estatura, double masa)
        {
            this.estatura = estatura;
            this.masa = masa;
            this.imc = this.masa / Math.Pow(this.estatura, 2);
        }

        public String ObtenerDiagnostico()
        {
            string diagnostico;

            if (imc < 16)
            {
                diagnostico = "Delgadez severa";
            }
            else if (imc < 17)
            {
                diagnostico = "Delgadez moderada";
            }
            else if (imc < 18.5)
            {
                diagnostico = "Delgadez leve";
            }
            else if (imc < 25)
            {
                diagnostico = "Peso normal";
            }
            else if (imc < 30)
            {
                diagnostico = "Preobesidad";
            }
            else if (imc < 35)
            {
                diagnostico = "Obesidad leve";
            }
            else if (imc < 40)
            {
                diagnostico = "Obesidad media";
            }
            else
            {
                diagnostico = "Obesidad mórbida";
            }

            return string.Format($"{Environment.NewLine} Masa: {masa:F2} kg" +
                $"{Environment.NewLine} Estatura: {estatura:F2} m" +
                $"{Environment.NewLine} Tu imc es: {imc:F3}" +
                $"{Environment.NewLine} Diagnostico: {diagnostico}" +
                $"{Environment.NewLine} Consulta a tu médico");
        }

    }
}
