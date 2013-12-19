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

            var actualValue = fizzBuzz.IsDivisibleByThree();

            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
