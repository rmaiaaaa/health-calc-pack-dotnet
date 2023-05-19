using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.MacroNutrienteStrategies;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacroNutrientesStrategyTest
    {

        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerderPeso, 231, 231, 308)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 308, 154, 308)]
        [InlineData(ObjetivoFisicoEnum.GanharPeso, 308, 77, 154)]
        public void CalcularMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {
            //Arrange
            MacroNutrientesContext strategy = new();
            double peso = 77;
            var macronutrienteEsperado = new MacroNutrientesModel()
            {
                Carboidratos = carboidratos,
                Gorduras = gorduras,
                Proteinas = proteinas,
            };

            switch (ObjetivoFisico)
            {
                case ObjetivoFisicoEnum.PerderPeso:
                    strategy.AtribuirStrategy(new PerderPesoStrategy());
                    break;
                case ObjetivoFisicoEnum.ManterPeso:
                    strategy.AtribuirStrategy(new ManterPesoStrategy());
                    break;
                case ObjetivoFisicoEnum.GanharPeso:
                    strategy.AtribuirStrategy(new GanharPesoStrategy());
                    break;
                default:
                    break;
            }

            var resultado = strategy.ExecutarStrategy(peso);

            Assert.Equivalent(macronutrienteEsperado, resultado);
            
        }
    }
}
