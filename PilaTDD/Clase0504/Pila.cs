using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0504
{
    public class Pila
    {
        private List<int> numeros;

        public Pila()
        {
            this.numeros = new List<int>();
        }

        public bool EsVacia()
        {
            return this.numeros.Count == 0;
        }

        public void Agregar(int numero)
        {
            this.numeros.Add(numero);
        }

        public int Ultimo()
        {
            if (this.EsVacia()) throw new PilaVaciaException();

            return this.numeros.Last();
        }

        public int Quitar()
        {
            if (this.EsVacia()) throw new PilaVaciaException();

            int ultimo = this.numeros.Last();

            this.numeros.RemoveAt(this.numeros.Count() - 1);

            return ultimo;
        }
    }
}
