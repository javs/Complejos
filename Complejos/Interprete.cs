using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Complejos
{
    public class Interprete
    {
        public string OperacionBasica(string opA, string op, string opB)
        {
            Complejo a = Complejo.Interpretar(opA);
            Complejo b = Complejo.Interpretar(opB);

            switch (op)
            {
                case "+":
                    return (a + b).ToString();
                case "-":
                    return (a - b).ToString();
                case "*":
                    return (a * b).ToString();
                case "/":
                    return (a / b).ToString();
                default:
                    throw new ErrorDeSintaxisException(
                        string.Format("Operador \"{0}\" desconocido.", op));
            }
        }
    }
}
