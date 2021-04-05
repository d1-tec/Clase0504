using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AjedrezTDD;
using System.Collections;
using System.Collections.Generic;

namespace AjedrezTDDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SiElPeonNoSeMovioMeOfreceDosCeldas()
        {
            // setup
            Tablero tablero = new Tablero();
            tablero.PosicionarPieza(new Peon(new Celda(2, 2)));
            
            //exercise
            List<Celda> posicionesDisponibles = tablero.PosicionesDisponibles(new Celda(2, 2));
            
            //verify
            CollectionAssert.AreEqual(posicionesDisponibles, new List<Celda> { new Celda(3, 2), new Celda(4, 2) });
        }

        [TestMethod]
        public void SiElPeonSeMovioSolamentePuedoAvanzarUnaCelda()
        {
            // setup
            Tablero tablero = new Tablero();
            tablero.PosicionarPieza(new Peon(new Celda(2, 2)));
            tablero.MoverPieza(new Celda(2, 2), new Celda(3, 2));

            //exercise
            List<Celda> posicionesDisponibles = tablero.PosicionesDisponibles(new Celda(3, 2));

            //verify
            CollectionAssert.AreEqual(posicionesDisponibles, new List<Celda> { new Celda(4, 2) });
        }
    }
}
