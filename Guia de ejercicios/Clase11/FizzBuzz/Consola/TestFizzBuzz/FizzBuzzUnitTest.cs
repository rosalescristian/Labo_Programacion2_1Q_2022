using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;

namespace TestFizzBuzz
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        /// <summary>
        /// Prueba si el nro es Divisible por Tres y retorna FIZZ
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 9;
            string expected = "Fizz";
            string actual;

            //Act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Prueba si el nro es Divisible por Cinco y retorna Buzz
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 20;
            string expected = "Buzz";
            string actual;

            //Act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Prueba si el nro es Divisible por Tres y por Cinco .Retorna FIZZBUZZ
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";
            string actual;

            //Act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Prueba si el nro no es Divisible por Tres O Cinco y retorna el mismo nro en String
        /// </summary>
        [TestMethod]
        [DataRow(4)] //     de esta forma puedo repetir varias veces                       el test con diferentes valores. Tengo q                      comentar el assert
        [DataRow(14)]
        [DataRow(11)]
        public void FizzBuzz_CuandoNoDivisiblePorTresYCinco_DeberiaRetornarMismoNro(int numero)
        {
            //Arrange
            //int numero = 7;
            string expected = numero.ToString();
            string actual = string.Empty;

            //Act
            actual = numero.FizzBuzz();

            //Assert
            //Assert.AreEqual(expected, actual); // linea original
            Assert.AreEqual(expected, actual);
        }
    }
}
