using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Constantes;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void calcularIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {

            IIMC imc = new IMC();
            double altura = 1.72;
            double peso = 78.2;
            double imcEsperado = 26.43;

            var resultado = imc.Calcular(altura, peso);

            Assert.Equal(imcEsperado, resultado);

        }

        [Fact]
        public void CalcularIMC_QuandoDadosInalidos_EntaoLevantaExcecao()
        {
            var imc = new IMC();
            double altura = 5;
            double peso = 70; 

            Assert.Throws<Exception>(() => imc.Calcular(altura, peso));

        }

        [Fact]
        public void ValidarDados_QuandoDadosInvalidos_EntaoRetornaFalso()
        {

            IIMC imc = new IMC();
            double altura = 15.0;
            double peso = 200.0;

            var resultado = imc.ValidarDados(altura, peso);

            Assert.False(resultado);

        }

        [Fact]
        public void ValidarDados_QuandoDadosValidos_EntaoRetornaVerdadeiro()
        {

            IIMC imc = new IMC();
            double altura = 1.40;
            double peso = 40.0;

            var resultado = imc.ValidarDados(altura, peso);

            Assert.True(resultado);

        }

        [Theory]
        [InlineData(18.49, ConstantesIMC.indiceMagreza)]
        [InlineData(18.50, ConstantesIMC.indiceNormal)]
        [InlineData(24.99, ConstantesIMC.indiceNormal)]
        [InlineData(25.00, ConstantesIMC.indiceSobrepeso)]
        [InlineData(29.99, ConstantesIMC.indiceSobrepeso)]
        [InlineData(30.00, ConstantesIMC.indiceObesidade)]
        [InlineData(39.99, ConstantesIMC.indiceObesidade)]
        [InlineData(40.00, ConstantesIMC.indiceObesidadeGrave)]
        public void RetornarCategoriaIMC_QuandoIndiceNormal_EntaoRetornaIndice(double valorIMC, string indiceEsperado)
        {

            IIMC imc = new IMC();

            var resultado = imc.ObterCategoriaIMC(valorIMC);

            Assert.Equal(indiceEsperado, resultado);

        }

    }
}