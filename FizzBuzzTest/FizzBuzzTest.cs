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
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(1);

            // Assert
            Assert.AreEqual("1", num);
        }

        [Test]
        public void TestNumero2()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(2);

            // Assert
            Assert.AreEqual("2", num);
        }

        [Test]
        public void TestNumero3()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(3);

            // Assert
            Assert.AreEqual("Fizz", num);
        }

        [Test]
        public void TestNumero4()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(4);

            // Assert
            Assert.AreEqual("4", num);
        }

        [Test]
        public void TestNumero5()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(5);

            // Assert
            Assert.AreEqual("Buzz", num);
        }

        [Test]
        public void TestNumero15()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(15);

            // Assert
            Assert.AreEqual("FizzBuzz", num);
        }

        [Test]
        public void TestNumero0()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(0);

            // Assert
            Assert.AreEqual("Error Numero Menor o Igual que Cero", num);
        }

        [Test]
        public void TestNumero1Negativo()
        {
            // Act
            var num = fizzBuzz.IsFizzOrBuzz(-1);

            // Assert
            Assert.AreEqual("Error Numero Menor o Igual que Cero", num);
        }
    }
}
