using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{

    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz.FizzBuzz fizzBuzz { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [Test]
        public void TestNumero1()
        {
            // Assert
            Assert.AreEqual("1", RefactorNumber(1));
        }

        [Test]
        public void TestNumero2()
        {
            // Assert
            Assert.AreEqual("2", RefactorNumber(2));
        }

        [Test]
        public void TestNumero3()
        {
            // Assert
            Assert.AreEqual("Fizz", RefactorNumber(3));
        }

        [Test]
        public void TestNumero4()
        {
            // Assert
            Assert.AreEqual("4", RefactorNumber(10));
        }

        [Test]
        public void TestNumero5()
        {
            // Assert
            Assert.AreEqual("Buzz", RefactorNumber(5));
        }

        [Test]
        public void TestNumero15()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(15);

            // Assert
            Assert.AreEqual("FizzBuzz", RefactorNumber(15));
        }

        [Test]
        public void TestNumero0()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(0);

            // Assert
            Assert.AreEqual("Error Numero Menor o Igual que Cero", RefactorNumber(0));
        }

        [Test]
        public void TestNumero1Negativo()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(-1);

            // Assert
            Assert.AreEqual("Error Numero Menor o Igual que Cero", RefactorNumber(-1));
        }

        [Test]
        public void TestNumero75()
        {
            // Assert
            Assert.AreEqual("FizzBuzz", RefactorNumber(75));
        }

        [Test]
        public void TestNumero9()
        {
            // Assert
            Assert.AreEqual("Fizz", RefactorNumber(9));
        }

        [Test]
        public void TestNumero10()
        {
            // Assert
            Assert.AreEqual("Buzz", RefactorNumber(10));
        }

        private string RefactorNumber(int num)
        {
            var numResul = fizzBuzz.IsFizzOrBuzz(num);
            return numResul;
        }
    }
}
