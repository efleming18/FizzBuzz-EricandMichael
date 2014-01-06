using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Unit_Tests
{
    [TestFixture]
    class IsDivisibleByThreeShould
    {
        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var expectedValue = true;

            var num = 15;
            var actualValue = fizzBuzz.IsDivisibleByThree(num);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var expectedValue = false;

            var num = 5;
            var actualValue = fizzBuzz.IsDivisibleByThree(num);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
