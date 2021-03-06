﻿using NUnit.Framework;
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
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var num = 15;
            Assert.IsTrue(fizzBuzz.IsDivisibleByThree(num));
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            var num = 5;
            Assert.IsFalse(fizzBuzz.IsDivisibleByThree(num));
        }
    }
}
