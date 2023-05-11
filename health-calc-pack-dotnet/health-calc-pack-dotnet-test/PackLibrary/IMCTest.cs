using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void calculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 1.72;
            double Weight = 78.2;
            double ExpectedIMC = 26.43;

            //Act
            var result = imc.Calc(Height, Weight);

            //Asserts
            Assert.Equal(ExpectedIMC, result);

        }

        [Fact]
        public void ValidaDados_IMCQuandoDadosValidos_EntaoRetornarVerdadeiro()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 15.0;
            double Weight = 200.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void ValidaDados_IMCQuandoDadosValidos_EntaoRetornarFalso()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndiceSobrepeso_EntaoRetornaSobrepeso()
        {

            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 26.43;
            string Expected = "SOBREPESO";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndiceMagreza_EntaoRetornaMagreza()
        {

            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 18;
            string Expected = "MAGREZA";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndicenNormal_EntaoRetornaNormal()
        {

            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 20;
            string Expected = "NORMAL";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndicenObesidade_EntaoRetornaObesidade()
        {

            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 30;
            string Expected = "OBESIDADE";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndicenObesidadeGrave_EntaoRetornaObesidadeGrave()
        {

            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 40;
            string Expected = "OBESIDADE GRAVE";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }
    }
}