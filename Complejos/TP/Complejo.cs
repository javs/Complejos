using System;
using System.Text.RegularExpressions;

namespace Complejos
{
    public class Complejo : IExpresion
    {
        public const double PI_2 = Math.PI * 2;
        public const double Epsilon = 1E-13;

        public enum Forma
        {
            Binomica,
            Polar,
        }
        
        public readonly double a;
        public readonly double b;
        public readonly Forma forma;
        public int precision { get; set; }
        

        public Complejo(double a = 0.0, double b = 1.0,
            Forma forma = Forma.Binomica)
        {
            this.a = a;
            this.b = b;
            this.forma = forma;
            this.precision = 2;

            if (forma == Forma.Polar)
            {
                // correccion del angulo asi queda siempre entre 0 < b < 2 pi
                if (Math.Abs(b) >= PI_2)
                    this.b = b % PI_2;
                
                if (this.b < 0.0)
                    this.b += 2 * Math.PI;
            }
        }

        public static bool Equals(double x, double y, double epsilon = Epsilon)
        {
            return Math.Abs(x - y) < epsilon;
        }

        public static bool NotEquals(double x, double y, double epsilon = Epsilon)
        {
            return Math.Abs(x - y) >= epsilon;
        }

        public override string ToString()
        {
            switch (forma)
            {
                case Forma.Binomica:
                    return ToStringBinomico();
                case Forma.Polar:
                    return ToStringPolar();
                default:
                    return "??";
            }
        }

        public Complejo Convertir(Forma aForma)
        {
            if (this.forma == Forma.Binomica)
            {
                if (aForma == Forma.Polar)
                {
                    return new Complejo(
                        Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0)),
                        Math.Atan2(b, a),
                        Forma.Polar);
                }
                else if (aForma == Forma.Binomica)
                {
                    return this;
                }
            }
            else if (this.forma == Forma.Polar)
            {
                if (aForma == Forma.Binomica)
                    return new Complejo(
                        a * Math.Cos(b),
                        a * Math.Sin(b),
                        Forma.Binomica);
                else if (aForma == Forma.Polar)
                    return this;
            }
            
            throw new Exception("Conversion no esperada a " + aForma);
        }

        public string ToStringPolar()
        {
            Convertir(Forma.Polar);

            return string.Format("[{0};{1}]",
                Math.Round(a, precision),
                Equals(b, 0)
                    ? Math.Round(b, precision).ToString()
                    : Math.Round(b / Math.PI, precision) + "pi");
        }

        public string ToStringBinomico()
        {
            Convertir(Forma.Binomica);

            if (Equals(a, 0.0) && Equals(b, 0.0))
                return "0";

            string primera = "";
            string signo = "";
            string segunda = "";

            if (NotEquals(a, 0.0))
                primera += Math.Round(a, precision);

            if (NotEquals(b, 0.0))
            {
                if (b < 0.0)
                    signo = "-";

                double b_abs = Math.Abs(b);

                // no mostrar 1 para j
                if (NotEquals(b_abs, 1.0))
                    segunda += Math.Round(b_abs, precision);

                segunda += "j";
            }

            // corregir los espacios
            if (primera != "" && segunda != "")
                signo = " " + (signo == "" ? "+" : signo) + " ";

            return primera + signo + segunda;
        }

        public static Complejo operator +(Complejo izq, Complejo der)
        {
            izq = izq.Convertir(Forma.Binomica);
            der = der.Convertir(Forma.Binomica);

            return new Complejo(izq.a + der.a, izq.b + der.b, Forma.Binomica);
        }

        public static Complejo operator -(Complejo izq, Complejo der)
        {
            izq = izq.Convertir(Forma.Binomica);
            der = der.Convertir(Forma.Binomica);

            return new Complejo(izq.a - der.a, izq.b - der.b, Forma.Binomica);
        }

        public static Complejo operator *(Complejo izq, Complejo der)
        {
            if (izq.forma != der.forma)
            {
                izq = izq.Convertir(Forma.Polar);
                der = der.Convertir(Forma.Polar);
            }

            if (izq.forma == Forma.Binomica)
                return new Complejo(
                    izq.a * der.a - izq.b * der.b,
                    izq.a * der.b + izq.b * der.a,
                    Forma.Binomica);
            else
                return new Complejo(izq.a * der.a, izq.b + der.b, Forma.Polar);
        }

        public static Complejo operator /(Complejo izq, Complejo der)
        {
            if (izq.forma != der.forma)
            {
                izq = izq.Convertir(Forma.Polar);
                der = der.Convertir(Forma.Polar);
            }

            if (izq.forma == Forma.Binomica)
            {
                var numerador = izq * der.Conjugado();
                var divisor = Math.Pow(der.a, 2) + Math.Pow(der.b, 2);

                return new Complejo(
                    numerador.a / divisor,
                    numerador.b / divisor,
                    Forma.Binomica);
            }
            else
                return new Complejo(izq.a / der.a, izq.b - der.b, Forma.Polar);
        }

        public Complejo Conjugado()
        {
            return new Complejo(a,-b, forma);
        }

        public override bool Equals(object otro)
        {
            if (otro == null)
                return false;

            Complejo c = otro as Complejo;

            if ((System.Object)c == null)
                return false;

            if (this.forma == c.forma)
                return Equals(this.a, c.a) && Equals(this.b, c.b);
            else // Si sus formas son distintas, convertir a binomico ya que es mas barato
                return this.Convertir(Forma.Binomica).Equals(c.Convertir(Forma.Binomica));
        }

        public override int GetHashCode()
        {
            int hash = 23;
            hash = hash * 31 + a.GetHashCode();
            hash = hash * 31 + b.GetHashCode();

            return hash;
        }

        public static bool Parsear(string expresion,
            out Complejo resultado, out int extraido)
        {
            const string NUMERO_DECIMAL = @"(?:\s*([+-]?\s*[\d]+[\.\,]?[\d]*)\s*)";

            Match m;

            // Binomico (a;b)
            m = Regex.Match(
                expresion,
                @"^\(" + NUMERO_DECIMAL + ";" + NUMERO_DECIMAL + @"\)",
                RegexOptions.Compiled);

            if (m.Success)
            {
                resultado = new Complejo(
                    double.Parse(m.Groups[1].Value),
                    double.Parse(m.Groups[2].Value),
                    Forma.Binomica);

                extraido = m.Length;

                return true;
            }

            // Polar [a;b]
            m = Regex.Match(
                expresion,
                @"^\[" + NUMERO_DECIMAL + ";" + NUMERO_DECIMAL + @"?(pi)?\]",
                RegexOptions.Compiled);

            if (m.Success)
            {
                var tiene_argumento = m.Groups[2].Success;
                var tiene_pi = m.Groups[3].Success;

                if (tiene_argumento || tiene_pi)
                {
                    var o = tiene_argumento
                        ? double.Parse(m.Groups[2].Value)
                        : 1.0;
                    
                    if (tiene_pi)
                        o *= Math.PI;

                    resultado = new Complejo(
                        double.Parse(m.Groups[1].Value),
                        o,
                        Forma.Polar);

                    extraido = m.Length;

                    return true;
                }
            }

            // Binomico a + bj
            // \todo - parseo manual ?

            resultado = null;
            extraido = 0;

            return false;
        }

        public IExpresion Interpretar()
        {
            return this;
        }
    }
}
