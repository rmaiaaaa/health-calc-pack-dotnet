using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet
{
    public class MacroNutrientes : IMacroNutrientes
    {
        public MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum objetivoFisico,  double peso)
        {

            if (!ValidarDados(peso))
            {
                throw new Exception("Peso inválido.");
            }

            if (objetivoFisico == ObjetivoFisicoEnum.PerderPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 3.0 * peso,
                    Gorduras = 3.0 * peso,
                    Proteinas = 4.0 * peso,
                };
            }
            else if (objetivoFisico == ObjetivoFisicoEnum.ManterPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * peso,
                    Gorduras = 2.0 * peso,
                    Proteinas = 4.0 * peso,
                };
            }
            else if (objetivoFisico == ObjetivoFisicoEnum.GanharPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * peso,
                    Gorduras = 1.0 * peso,
                    Proteinas = 2.0 * peso,
                };
            }
            else
            {
                return new MacroNutrientesModel();
            }

        }

        public bool ValidarDados(double peso)
        {
            return (peso > 0.0);
        }
    }
}
