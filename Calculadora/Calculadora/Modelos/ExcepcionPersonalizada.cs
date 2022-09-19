using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Modelos
{
    internal class ExcepcionPersonalizada:Exception
    {
        public ExcepcionPersonalizada():base("Execpcion Personalizada"){}
    }
}
