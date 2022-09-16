using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Clases
{
    public class Omnibus:TransportePublico
    {
        public Omnibus(int pasajero) : base(pasajero)
        {
        }
        public override string Avanzar()
        {
            return $"omnibus avanzo con {Pasajero} pasajeros";
        }
        public override string Detenerse()
        {
            return $"omnibus me detengo {Pasajero} pasajeros";
        }
    }
}
