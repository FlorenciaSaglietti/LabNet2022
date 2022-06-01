using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Tests
{
    [TestClass()]
    public class DivisiónTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //arrange
            var division = new División();
            var Numero1 = 20;
            var Numero2 = 10;

            //act
            var resultado = division.Dividir(Numero1, Numero2);

            //assert
            Assert.AreEqual(2, resultado);
        }

        [TestMethod()]
        public void DividirTest2()
        {
            //arrange
            var division = new División();
            var Numero1 = 20;
            var Numero2 = -10;

            //act
            var resultado = division.Dividir(Numero1, Numero2);

            //assert
            Assert.AreEqual(-2, resultado);
        }
    }
}