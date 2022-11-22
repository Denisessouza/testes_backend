using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestarIMC;
using TesteImc;

namespace TestarIMC
{
    //Classe de Testes que você queira executar

    [TestClass]

    public class CalculoImcTests
    {
        // método de teste
        [TestMethod]
        public void CalcularIMC()
        {
            // Arrange - Òrganizar e preparar o Teste
            double peso = 110;
            double altura = 1.79;


            // Act - Agir/Execução/ Chamada do Método 

            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            // Assert - Comportamento Esperado, comportamento Obtido 
            Assert.AreEqual(34.33, resultadoIMC);
        }

    }
}
