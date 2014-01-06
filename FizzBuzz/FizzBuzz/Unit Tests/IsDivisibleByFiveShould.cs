using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Unit_Tests
{
    [TestFixture]
    class IsDivisibleByFiveShould
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [Test]
        public void ReturnTrueIfNumberDivisibleByFive()
        {
            var num = 5;
            Assert.IsTrue(fizzBuzz.IsDivisibleByFive(num));
        }

        [Test]
        public void ReturnFalseIfNumberNotDivisibleByFive()
        {
            var num = 3;
            Assert.IsFalse(fizzBuzz.IsDivisibleByFive(num));
        }
    }
}
