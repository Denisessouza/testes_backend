using System.Runtime.CompilerServices;
using TesteImc;
using Xunit;


namespace TesteIMCXunit
{

    public class CalculoIMCtests
    {
        //Método de Teste
        [Fact]

        public void CalcularIMC_RetornaResultado()
        {
            //Arrange - Organizar e preparar o teste
            double peso = 110;
            double altura = 1.79;

            // Act - Execução e Chamada do Método
            var resultado = Operacoes.CalcularIMC(peso, altura);


            //Assert - Comportamento esperado e comparação com o resultado obtido
            Assert.Equal(34.33, resultado);

        }
        [Theory]
        [InlineData(80,1.79,24.97)]
        [InlineData(100, 1.79, 31.21)]
        public void CalcularIMC_RetornaResultado_ParaUmaListadeValores(double pNum, double sNUm, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(pNum, sNUm);
            Assert.Equal(resultadoEsperado, resultadoIMC);
        }

    }

}
