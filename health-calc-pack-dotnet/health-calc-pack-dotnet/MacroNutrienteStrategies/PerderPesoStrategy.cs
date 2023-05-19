using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.MacroNutrienteStrategies
{
    public class PerderPesoStrategy : IMacroNutrientesStrategy
    {
        public MacroNutrientesModel CalcularMacroNutrientes( double Peso)
        {
            return new MacroNutrientesModel()
            {
                Carboidratos = 3.0 * Peso,
                Gorduras = 3.0 * Peso,
                Proteinas = 4.0 * Peso,
            };
        }
    }
}
