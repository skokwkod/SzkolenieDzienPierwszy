using System;
using lab39___TestyJednostkowe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _39___TestyJednostkoweTest
{
    [TestClass]
    public class KalkulatorTest
    {
        [TestMethod]
        public void DodajTest()
        {
            decimal x = 4;
            decimal y = 2;

            var result = Kalkulator.Dodaj(x, y);

            Assert.AreEqual(result, 6);
        }
        [TestMethod]
        public void OdejmijTest()
        {
            decimal x = 4;
            decimal y = 2;

            var result = Kalkulator.Odejmij(x, y);

            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void PomnozTest()
        {
            decimal x = 4;
            decimal y = 2;

            var result = Kalkulator.Pomnoz(x, y);

            Assert.AreEqual(result, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PodzielTest_0_Argument()
        {
            decimal x = 4;
            decimal y = 0;

            var result = Kalkulator.Podziel(x, y);

           // Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void PodzielTest()
        {
            decimal x = 4;
            decimal y = 2;

            var result = Kalkulator.Podziel(x, y);

            Assert.AreEqual(result, 2);
        }


    }
}
