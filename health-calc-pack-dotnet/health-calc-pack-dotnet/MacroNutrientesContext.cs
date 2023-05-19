using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet
{
    public class MacroNutrientesContext
    {

        private IMacroNutrientesStrategy? strategy;

        public void AtribuirStrategy(IMacroNutrientesStrategy strategy)
        {
            this.strategy = strategy;
        }

        public MacroNutrientesModel ExecutarStrategy(double Peso)
        {
            return strategy!.CalcularMacroNutrientes(Peso);
        }
    }
}
