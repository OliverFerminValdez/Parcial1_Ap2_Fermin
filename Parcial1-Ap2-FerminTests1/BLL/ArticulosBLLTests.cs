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
            Articulos articulos = ArticulosBLL.Buscar(3);
            articulos.Descripcion = "Uvas Moradas";
            bool modificado = ArticulosBLL.Modificar(articulos);

            Assert.AreEqual(true, modificado);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulos = new Articulos();

            articulos.ArticuloId = 1;
            articulos.Descripcion = "Manzanas";
            articulos.Costo = 30;
            articulos.Existencia = 4;
            articulos.ValorInventario = 120;

            bool guardo = ArticulosBLL.Guardar(articulos);

            Assert.AreEqual(guardo, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulos encontrado = ArticulosBLL.Buscar(1);

            Assert.IsNotNull(encontrado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool eliminado = ArticulosBLL.Eliminar(4);

            Assert.AreEqual(eliminado, true);
        }

        [TestMethod()]
        public void GetArticulosTest()
        {
            List<Articulos> lista = new List<Articulos>();

            lista = ArticulosBLL.GetArticulos(a => true);

            Assert.IsNotNull(lista);
        }
    }
}