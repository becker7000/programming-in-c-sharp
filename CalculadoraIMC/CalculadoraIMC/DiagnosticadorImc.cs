using System;

namespace CalculadoraIMC
{
    public class DiagnosticadorImc
    {

        private double masa;
        private double estatura;
        private double imc;

        public DiagnosticadorImc(double masa, double estatura)
        {
            this.masa = masa;
            this.estatura = estatura;
            this.imc = masa / Math.Pow(estatura, 2);

        }

        public String ObtenerDiagnostico()
        {
            String diagnostico;

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
                diagnostico = "Obesisdad media";
            }
            else
            {
                diagnostico = "Obesidad mórbida";
            }

            return string.Format($"{Environment.NewLine} Masa: {masa} kg " +
                $"{Environment.NewLine} Estatura: {estatura} m " +
                $"{Environment.NewLine} Índice de masa corporal: {imc:F3} " +
                $"{Environment.NewLine} Diagnositico: {diagnostico} ");
        }
    }
}
