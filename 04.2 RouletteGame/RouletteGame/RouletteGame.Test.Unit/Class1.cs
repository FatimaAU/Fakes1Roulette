using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame;

namespace RouletteGame.Test.Unit
{
    public class RouletteGameTestUnit
    {
        [TestFixture]
            [Author("Troels Jensen")]
        public class CalculatorUnitTests
        {
            private RouletteGame _uut;

            [SetUp]
            public void Setup()
            {
                _uut = new Calculator();
            }
        }
}
