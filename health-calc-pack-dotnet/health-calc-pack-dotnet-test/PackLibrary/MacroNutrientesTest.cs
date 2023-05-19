using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacroNutrientesTest
    {

        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerderPeso, 231, 231, 308)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 308, 154, 308)]
        [InlineData(ObjetivoFisicoEnum.GanharPeso, 308, 77, 154)]
        public void CalcularMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {

            MacroNutrientes macroNutrientes = new MacroNutrientes();
            double peso = 77;
            var macronutrienteEsperado = new MacroNutrientesModel()
            {
                Carboidratos = carboidratos,
                Gorduras     = gorduras,
                Proteinas    = proteinas,
            };

            var resultado = macroNutrientes.CalcularMacroNutrientes(ObjetivoFisico, peso);

            Assert.Equivalent(macronutrienteEsperado, resultado);
        
        }

        [Fact]
        public void CalcularMacroNutrientes_QuandoDadosInvalidos_EntaoLevantaExcecao()
        {
            MacroNutrientes macroNutrientes = new MacroNutrientes();
            double peso = 0;

            Assert.Throws<Exception>(() => macroNutrientes.CalcularMacroNutrientes(0, peso));

        }

        [Fact]
        public void ValidarPeso_QuandoDadoInvalido_EntaoRetornaFalso()
        {
            
            MacroNutrientes macroNutrientes = new();
            double peso = 0; 

            var resultado = macroNutrientes.ValidarDados(peso);

            Assert.False(resultado);

        }

        [Fact]
        public void ValidarPeso_QuandoDadoValido_EntaoRetornaVerdadeiro()
        {
            
            MacroNutrientes macroNutrientes = new();
            double peso = 77;

            var resultado = macroNutrientes.ValidarDados(peso);

            Assert.True(resultado);

        }

    }
}
