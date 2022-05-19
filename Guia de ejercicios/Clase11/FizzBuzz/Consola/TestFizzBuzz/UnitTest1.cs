using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Biblioteca;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Prueba si el nro es Divisible por Tres y retorna FIZZ
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int i = 3;
            string expected = "Fizz";
            string actual;

            //Act
            actual = i.FizzBuzz();

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
            int i = 5;
            string expected = "Buzz";
            string actual;

            //Act
            actual = i.FizzBuzz();

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
            int i = 15;
            string expected = "FizzBuzz";
            string actual;

            //Act
            actual = i.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Prueba si el nro no es Divisible por Tres O Cinco y retorna el mismo nro en String
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoNoDivisiblePorTresOCinco_DeberiaRetornarMismoNro()
        {
            //Arrange
            int i = 7;
            string expected = i.ToString();
            string actual;

            //Act
            actual = i.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
