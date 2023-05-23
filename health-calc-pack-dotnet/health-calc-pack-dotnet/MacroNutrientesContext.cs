using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet
{
    public class MacroNutrientesContext
    {

        private IMacroNutrientesStrategy? strategy;

        public void AtribuirStrategy(IMacroNutrientesStrategy strategy)
        {
            this.strategy = strategy;
        }

        public MacroNutrientesModel ExecutarStrategy(double peso)
        {
            return strategy!.CalcularMacroNutrientes(peso);
        }
    }
}
