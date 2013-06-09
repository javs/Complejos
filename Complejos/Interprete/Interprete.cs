using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Complejos
{
    public class Interprete : IExpresion
    {
        private IExpresion arbol;

        public Interprete(string texto)
        {
        }

        public IExpresion Interpretar()
        {
            return arbol.Interpretar();
        }
    }
}
