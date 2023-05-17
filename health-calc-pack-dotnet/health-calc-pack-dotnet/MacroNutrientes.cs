using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet
{
    public class MacroNutrientes : IMacroNutrientes
    {
        public MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum ObjetivoFisico,  double Peso)
        {
            if (ObjetivoFisico == ObjetivoFisicoEnum.PerderPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 3.0 * Peso,
                    Gorduras = 3.0 * Peso,
                    Proteinas = 4.0 * Peso,
                };
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.ManterPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Gorduras = 2.0 * Peso,
                    Proteinas = 4.0 * Peso,
                };
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.GanharPeso)
            {
                return new MacroNutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Gorduras = 1.0 * Peso,
                    Proteinas = 2.0 * Peso,
                };
            }
            else
            {
                return new MacroNutrientesModel();
            }

        }
    }
}
