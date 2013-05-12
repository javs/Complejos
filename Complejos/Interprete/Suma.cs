using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos.Interprete
{
    class Suma : IExpresion
    {
        public readonly IExpresion izq;
        public readonly IExpresion der;

        Suma(IExpresion izq, IExpresion der)
        {
            this.izq = izq;
            this.der= der;
        }

        IExpresion Interpretar()
        {
            return izq + der;
        }
    }
}
