using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    class Suma : IExpresion
    {
        private readonly dynamic izq;
        private readonly dynamic der;

        public Suma(IExpresion izq, IExpresion der)
        {
            this.izq = izq;
            this.der = der;
        }

        public IExpresion Interpretar()
        {
            return izq.Interpretar() + der.Interpretar();
        }
    }
}
