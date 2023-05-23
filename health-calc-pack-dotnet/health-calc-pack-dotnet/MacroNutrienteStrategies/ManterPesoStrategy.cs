using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.MacroNutrienteStrategies
{
    public class ManterPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalcularMacroNutrientes(double peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 4.0 * peso,
                Gorduras = 2.0 * peso,
                Proteinas = 4.0 * peso,
            };
        }
    }
}
