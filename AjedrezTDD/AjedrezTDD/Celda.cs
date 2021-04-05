using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezTDD
{
    public class Celda
    {
        public int Fila { get; private set; }
        public int Columna { get; private set; }

        public Celda(int fila, int columna)
        {
            this.Fila = fila;
            this.Columna = columna;
        }

        public override bool Equals(object obj)
        {
            Celda otraCelda = obj as Celda;

            if (otraCelda == null) return false;

            return this.Fila.Equals(otraCelda.Fila) && this.Columna.Equals(otraCelda.Columna);
        }
    }
}
