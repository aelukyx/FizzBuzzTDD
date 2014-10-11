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
    }

}
