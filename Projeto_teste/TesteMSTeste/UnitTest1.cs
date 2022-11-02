using Projeto_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void SomarDoisNumeros()
        {
            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(1,1,2)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert
            Assert.AreEqual(rNum, resultado);
        }
    }
}