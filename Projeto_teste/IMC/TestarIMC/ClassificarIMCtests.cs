

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestarIMC;
    using TesteImc;

    namespace TestarIMC
    {
        //Classe de Testes que você queira executar

        [TestClass]

        public class ClassificarImcTests
        {
            // método de teste
            [TestMethod]
            public void ClassificarIMC()
            {
            // Arrange - Òrganizar e preparar o Teste
            double imc = 28;


                // Act - Agir/Execução/ Chamada do Método 

                var ClassificacaoIMC = Operacoes.ClassificarIMC(imc);

                // Assert - Comportamento Esperado, comportamento Obtido 
                Assert.AreEqual("Sobrepeso", ClassificacaoIMC);
            }

        }
    }

