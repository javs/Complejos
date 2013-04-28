using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Complejos
{
    public class ErrorDeSintaxisException : Exception
    {
        public ErrorDeSintaxisException(string message) : base(message)
        {
        }
    }

    public class Interprete
    {
        public string Operacion(string texto)
        {
            Match m = Regex.Match(texto,
                @"\(\s*(-?[\d]+.?[\d]*)\s*,\s*(-?[\d]+.?[\d]*)\s*\)" +    // (a,b)
                @"\s*(\S)\s*" +                         // <operador>
                @"\(\s*(-?[\d]+.?[\d]*)\s*,\s*(-?[\d]+.?[\d]*)\s*\)",     // (a,b)
                RegexOptions.Compiled);

            if (!m.Success)
                throw new ErrorDeSintaxisException(
                    "Se esperan dos expresioned de la forma (a,b) combinadas con un operador");

            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            var op1 = new Complejo(
                double.Parse(m.Groups[1].Value, format),
                double.Parse(m.Groups[2].Value, format));

            var op2 = new Complejo(
                double.Parse(m.Groups[4].Value, format),
                double.Parse(m.Groups[5].Value, format));

            switch (m.Groups[3].Value)
            {
                case "+":
                    return (op1 + op2).ToString();
                case "-":
                    return (op1 - op2).ToString();
                case "*":
                case "/":
                    throw new ErrorDeSintaxisException(
                        string.Format("Operacion \"{0}\" no implementada.", m.Groups[3].Value));
                default:
                    throw new ErrorDeSintaxisException(
                        string.Format("Operador \"{0}\" desconocido.", m.Groups[3].Value));
            }
        }
    }
}
