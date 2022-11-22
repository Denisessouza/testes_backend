using TestarIMC;
using TesteImc;
using Xunit;

namespace TesteIMCXunit
{
    public class ClassificarIMCtests
    {
        [Fact]  
        // descrição do teste
        public void ClassificarIMC_RetornaResultado()
        {
            //Arrange 
            double imc = 28;
            //Act
            var ClassificacaoIMC = Operacoes.ClassificarIMC(imc);
            // Assert
            Assert.Equal("Sobrepeso", ClassificacaoIMC);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado_ParaUmaListadeValores(double pNum, string ResultadoEsperado)
        {
            var ResultadodoIMC = Operacoes.ClassificarIMC(pNum);
            Assert.Equal(ResultadoEsperado, ResultadodoIMC);
        }
    }
}
