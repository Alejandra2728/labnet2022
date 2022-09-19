using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Modelos
{
    public class Logic
    {
       
        private int _intEdad;
        public int Edad
        {
            get { return _intEdad; }
            set
            {
                _intEdad = value;
                if (_intEdad < 0 || _intEdad > 100)
                    throw new IndexOutOfRangeException("Dato fuera de rango en la edad");
            }
        }

        public void CapturoExcepcionPersonalizada()
        {
            throw new ExcepcionPersonalizada();
        }
 
    }
}
