using health_calc_pack_dotnet.Interfaces;
using System.Numerics;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            double calculo = Weight / Math.Pow(Height, 2);
            return Math.Round(calculo,2);
        }

        public string GetIMCCategory(double IMC)
        {

            var result = string.Empty;
            if (IMC < 18.5)
                result = "MAGREZA";
            else if (IMC >= 18.5 && IMC < 25)
                result = "NORMAL";
            else if (IMC >= 25 && IMC < 30)
                result = "SOBREPESO";
            else if (IMC >= 30 && IMC < 40)
                result = "OBESIDADE";
            else if (IMC >= 40)
                result  = "OBSIDADE GRAVE";

            return result;

        }

        public bool IsValidData(double Height, double Weight)
        {
            return (Height < 3.0 && Weight <= 300);
        }
    }
}
