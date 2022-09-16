using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Clases
{
    public abstract class TransportePublico
    {
        private int pasajero;
        public int Pasajero
        {
            get { return pasajero; }
            set { pasajero = value; }
        }
        public TransportePublico(int pasajero)
        {
            Pasajero = pasajero;
        }
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
