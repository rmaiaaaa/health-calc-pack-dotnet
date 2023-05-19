using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientesStrategy
    {
        MacroNutrientesModel CalcularMacroNutrientes(double Peso);         
    }
}
