using health_calc_pack_dotnet;
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
            
            var resultado= imc.Calcular(altura, peso);
            
            Assert.Equal(imcEsperado, resultado);

        }

        [Fact]
        public void ValidarDados_QuandoDadosInvalidos_EntaoRetornaFalso()
        {
            
            IIMC imc = new IMC();
            double altura = 15.0;
            double peso= 200.0;
            
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

        [Fact]
        public void RetornarCategoriaIMC_QuandoIndiceSobrepeso_EntaoRetornaSobrepeso()
        {
            
            IIMC imc = new IMC();
            double valorIMC = 26.43;
            string indiceEsperado = "SOBREPESO";
            
            var resultado = imc.ObterCategoriaIMC(valorIMC);
            
            Assert.Equal(indiceEsperado, resultado);

        }

        [Fact]
        public void RetornarCategoriaIMC_QuandoIndiceMagreza_EntaoRetornaMagreza()
        {
            
            IIMC imc = new IMC();
            double valorIMC = 18;
            string indiceEsperado = "MAGREZA";
            
            var resultado = imc.ObterCategoriaIMC(valorIMC);
            
            Assert.Equal(indiceEsperado, resultado);

        }

        [Fact]
        public void RetornarCategoriaIMC_QuandoIndiceNormal_EntaoRetornaNormal()
        {
            
            IIMC imc = new IMC();
            double valorIMC = 20;
            string indiceEsperado = "NORMAL";
            
            var resultado = imc.ObterCategoriaIMC(valorIMC);
            
            Assert.Equal(indiceEsperado, resultado);

        }

        [Fact]
        public void RetornarCategoriaIMC_QuandoIndiceObesidade_EntaoRetornaObesidade()
        {
            
            IIMC imc = new IMC();
            double valorIMC = 30;
            string indiceEsperado = "OBESIDADE";
            
            var resultado = imc.ObterCategoriaIMC(valorIMC);
            
            Assert.Equal(indiceEsperado, resultado);

        }

        [Fact]
        public void RetornarCategoriaIMC_QuandoIndiceObesidadeGrave_EntaoRetornaObesidadeGrave()
        {
            
            IIMC imc = new IMC();
            double valorIMC = 40;
            string indiceEsperado = "OBESIDADE GRAVE";
            
            var resultado = imc.ObterCategoriaIMC(valorIMC);
            
            Assert.Equal(indiceEsperado, resultado);

        }
    }
}