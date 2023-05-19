using health_calc_pack_dotnet.Interfaces;
using System.Numerics;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calcular(double altura, double peso)
        {
            if (!ValidarDados(altura, peso)) 
            {
                throw new Exception("Peso e/ou altura inválidos.");
            }

            double calculo = peso / Math.Pow(altura, 2);
            return Math.Round(calculo,2);
        }

        public string ObterCategoriaIMC(double imc)
        {
            var result = string.Empty;
            if (imc < 18.5)
                result = "MAGREZA";
            else if (imc >= 18.5 && imc < 25)
                result = "NORMAL";
            else if (imc >= 25 && imc < 30)
                result = "SOBREPESO";
            else if (imc >= 30 && imc < 40)
                result = "OBESIDADE";
            else if (imc >= 40)
                result = "OBESIDADE GRAVE";

            return result;
        }

        public bool ValidarDados(double altura, double peso)
        {
            return (altura < 3.0 && peso <= 300);
        }
    }
}
