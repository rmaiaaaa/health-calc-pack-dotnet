using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.MacroNutrienteStrategies
{
    public class GanharPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalcularMacroNutrientes(double peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 4.0 * peso,
                Gorduras = 1.0 * peso,
                Proteinas = 2.0 * peso,
            };
        }
    }
}
