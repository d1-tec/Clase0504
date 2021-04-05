using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezTDD
{
    public class Peon
    {
        private Celda celda;
        private bool primerMovimiento;

        public Peon(Celda celda)
        {
            this.celda = celda;
            this.primerMovimiento = true;
        }

        public bool EstaEnLaCelda(Celda celda)
        {
            return this.celda.Equals(celda);
        }

        public List<Celda> PosiblesMovimientos()
        {
            if (this.primerMovimiento)
            {
                return new List<Celda>() { new Celda(this.celda.Fila + 1, this.celda.Columna), new Celda(this.celda.Fila + 2, this.celda.Columna) };
            }
            else
            {
                return new List<Celda>() { new Celda(this.celda.Fila + 1, this.celda.Columna) };
            }
        }

        public void Mover(Celda destino)
        {
            if (this.celda.Columna.Equals(destino.Columna))
            {
                int filaOrigen = this.celda.Fila;
                int filaDestino = destino.Fila;

                int diferenciaDeFilas = filaDestino - filaOrigen;

                if (diferenciaDeFilas == 2 || diferenciaDeFilas == 1)
                {
                    this.celda = destino;
                    this.primerMovimiento = false;
                }
            }
        }
    }
}
