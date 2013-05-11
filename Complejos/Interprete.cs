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
            //! \todo mejorar
            Match m;
            Complejo.Forma forma;
            
            m = Regex.Match(texto,
                @"\(\s*(-?[\d]+\.?[\d]*)\s*,\s*(-?[\d]+\.?[\d]*)\s*\)" +    // (a,b)
                @"\s*(\S)\s*" +                                           // <operador>
                @"\(\s*(-?[\d]+\.?[\d]*)\s*,\s*(-?[\d]+\.?[\d]*)\s*\)",     // (a,b)
                RegexOptions.Compiled);

            if (m.Success)
                forma = Complejo.Forma.Binomica;
            else
            {
                m = Regex.Match(texto,
                    @"\[\s*(-?[\d]+\.?[\d]*)\s*;\s*(-?[\d]+\.?[\d]*)\s*\]" +    // [a;b]
                    @"\s*(\S)\s*" +                                           // <operador>
                    @"\[\s*(-?[\d]+\.?[\d]*)\s*;\s*(-?[\d]+\.?[\d]*)\s*\]",     // [a;b]
                    RegexOptions.Compiled);

                if (m.Success)
                    forma = Complejo.Forma.Polar;
                else
                    throw new ErrorDeSintaxisException(
                        "Se esperan dos expresiones de la forma (a,b) o [a;b] operadas");
            }

            var formato = new NumberFormatInfo();
            formato.NumberDecimalSeparator = ".";

            var op1 = new Complejo(
                double.Parse(m.Groups[1].Value, formato),
                double.Parse(m.Groups[2].Value, formato), forma);

            var op2 = new Complejo(
                double.Parse(m.Groups[4].Value, formato),
                double.Parse(m.Groups[5].Value, formato), forma);

            switch (m.Groups[3].Value)
            {
                case "+":
                    return (op1 + op2).ToString();
                case "-":
                    return (op1 - op2).ToString();
                case "*":
                    return (op1 * op2).ToString();
                case "/":
                    return (op1 / op2).ToString();
                default:
                    throw new ErrorDeSintaxisException(
                        string.Format("Operador \"{0}\" desconocido.", m.Groups[3].Value));
            }
        }
    }
}
