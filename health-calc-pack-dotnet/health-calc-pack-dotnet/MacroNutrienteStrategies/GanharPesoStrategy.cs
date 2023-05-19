using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.MacroNutrienteStrategies
{
    public class GanharPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalcularMacroNutrientes(double Peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 4.0 * Peso,
                Gorduras = 1.0 * Peso,
                Proteinas = 2.0 * Peso,
            };
        }
    }
}
