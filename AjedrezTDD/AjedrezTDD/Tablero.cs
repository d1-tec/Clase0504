using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezTDD
{
    public class Tablero
    {
        private List<Peon> peones;

        public Tablero()
        {
            peones = new List<Peon>();
        }

        public void PosicionarPieza(Peon peon)
        {
            this.peones.Add(peon);
        }

        public List<Celda> PosicionesDisponibles(Celda celda)
        {
            Peon peon = this.BuscarPeon(celda);

            return peon.PosiblesMovimientos();
        }

        public void MoverPieza(Celda origen, Celda destino)
        {
            Peon peonQueEstaEnElOrigen = this.BuscarPeon(origen);

            peonQueEstaEnElOrigen.Mover(destino);
        }

        private Peon BuscarPeon(Celda celda)
        {
            return this.peones.Find(peon => peon.EstaEnLaCelda(celda));
        }
    }
}
