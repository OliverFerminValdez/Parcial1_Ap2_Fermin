using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap2_Fermin.BLL;
using Parcial1_Ap2_Fermin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Ap2_Fermin.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void ExisteTest()
        {
            bool encontrado = ArticulosBLL.Existe(1);

            Assert.AreEqual(true,encontrado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetArticulosTest()
        {
            Assert.Fail();
        }
    }
}