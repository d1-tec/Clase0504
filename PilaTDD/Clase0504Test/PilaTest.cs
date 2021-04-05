using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clase0504;

namespace Clase0504Test
{
    [TestClass]
    public class PilaTest
    {
        [TestMethod]
        public void SeCreaUnaPilaYLaPilaEsVacia()
        {
            // SETUP
            Pila pila = new Pila();

            // EXERCISE
            bool esVacia = pila.EsVacia();

            // VERIFY
            Assert.IsTrue(esVacia);
        }

        [TestMethod]
        public void UnaPilaConUnElementoNoEsVacia()
        {
            // SETUP
            Pila pila = new Pila();
            pila.Agregar(10);

            // EXERCISE
            bool esVacia = pila.EsVacia();

            // verify
            Assert.IsFalse(esVacia);
        }

        [TestMethod]
        public void SeDevuelveElUltimoElementoAgregado()
        {
            // setup
            Pila pila = new Pila();
            pila.Agregar(10);
            pila.Agregar(11);

            // exercise
            int ultimoAgregado = pila.Ultimo();

            // verify
            Assert.AreEqual(11, ultimoAgregado);
        }

        [TestMethod]
        public void SeDevuelveElUnicoElemento()
        {
            Pila pila = new Pila();
            pila.Agregar(5);
            Assert.AreEqual(5, pila.Ultimo());
        }

        [TestMethod]
        [ExpectedException(typeof(PilaVaciaException))]
        public void SiLaPilaEsVaciaElUltimoElementoDevuelveError()
        {
            // setup
            Pila pila = new Pila();

            // exercise
            pila.Ultimo();
        }

        [TestMethod]
        [ExpectedException(typeof(PilaVaciaException))]
        public void SiLaPilaEsVaciaQuitarDevuelveUnError()
        {
            Pila pila = new Pila();
            pila.Quitar();
        }

        [TestMethod]
        public void SiLaPilaNoEsVaciaQuitarDevuelveElUltimoElemento()
        {
            Pila pila = new Pila();
            pila.Agregar(11);
            Assert.AreEqual(11, pila.Quitar());
        }

        [TestMethod]
        public void SiLaPilaTieneUnUnicoElementoQuitarLaDejaVacia()
        {
            Pila pila = new Pila();
            pila.Agregar(11);
            pila.Quitar();
            Assert.IsTrue(pila.EsVacia());
        }
    }
}
