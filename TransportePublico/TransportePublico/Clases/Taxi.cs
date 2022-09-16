using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico.Clases
{
    public class Taxi: TransportePublico
    {
        public Taxi(int pasajero) : base(pasajero)
        {
        }
        public override string Avanzar()
        {
            return $"Taxi avanzo con {Pasajero} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Taxi me detengo con {Pasajero} pasajeros";
        }
    }
}
