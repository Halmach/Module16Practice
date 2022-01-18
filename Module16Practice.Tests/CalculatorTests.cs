using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module16Practice.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(100, 37) == 137);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.AreEqual(calc.Subtraction(100, 37), 63);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.AreEqual(calc.Multiplication(-100, 37), -3700);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Division(-100, -1) == 100);
        }

        [Test]
        public void DivisionnMustThrowExeption()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(10, 0));
        }

    }
}
