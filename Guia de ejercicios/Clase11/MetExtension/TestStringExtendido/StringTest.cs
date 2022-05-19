using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestStringExtendido
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorEspacio_DeberiaRetornarDos()
        {
            //Arrange - Inicializo las variables u objetos que necesito PROBAR
            string texto = "Hola ";
            int expected = 2; //Valor Esperado va asi por convencion
            int actual;

            //Act - Invoco el metodo a probar
            actual = texto.ContarPalabras();

            //Assert - Evaluo los resultados
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //Arrange - Inicializo las variables u objetos que necesito PROBAR
            string texto = "Hola-mundo";
            int expected = 2; //Valor Esperado va asi por convencion
            int actual;

            //Act - Invoco el metodo a probar
            actual = texto.ContarPalabras();

            //Assert - Evaluo los resultados
            Assert.AreEqual(expected, actual);
        }
    }
}
