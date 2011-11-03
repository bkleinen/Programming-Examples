using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace ClassLibrary1
{
    [TestFixture]
    class MyMathTest
    {
        [Test]
        public void GreatestCommonDivisor() {
            MyMath math = new MyMath();
            Assert.That(math.GreatestCommonDivisor(1, 1), Is.EqualTo(1));
            Assert.That(math.GreatestCommonDivisor(6, 3), Is.EqualTo(3));
            Assert.That(math.GreatestCommonDivisor(14, 21), Is.EqualTo(7));
            Assert.That(math.GreatestCommonDivisor(144, 48), Is.EqualTo(48));
            Assert.That(math.GreatestCommonDivisor(144, 60), Is.EqualTo(12));
            Assert.That(math.GreatestCommonDivisor(21, 15), Is.EqualTo(3));
            Assert.That(math.GreatestCommonDivisor(57, 7), Is.EqualTo(1));
        }

    }
}
