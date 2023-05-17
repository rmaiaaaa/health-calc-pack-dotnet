using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    internal interface IMacroNutrientes
    {
        MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum ObjetivoFisico, double Peso);         
    }
}
