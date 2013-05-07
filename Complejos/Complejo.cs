using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    public class Complejo
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
        

        public Complejo(double a = 0.0, double b = 1.0,
            Forma forma = Forma.Binomica)
        {
            this.a = a;
            this.b = b;
            this.forma = forma;

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
                    double r, o;

                    r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    o = Math.Atan2(b, a);

                    return new Complejo(r, o, Forma.Polar);
                }
                else if (aForma == Forma.Binomica)
                {
                    return this;
                }
            }
            else if (this.forma == Forma.Polar)
            {
                if (aForma == Forma.Binomica)
                    return new Complejo(a * Math.Cos(b), a * Math.Sin(b));
                else if (aForma == Forma.Polar)
                    return this;
            }
            
            throw new Exception("Conversion no esperada a " + aForma);
        }

        public string ToStringPolar()
        {
            Convertir(Forma.Polar);

            return string.Format("[{0};{1}]",
                a,
                Equals(b, 0)
                    ? b.ToString()
                    : (b / Math.PI) + "pi");
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
                primera += a;

            if (NotEquals(b, 0.0))
            {
                if (b < 0.0)
                    signo = "-";

                double b_abs = Math.Abs(b);

                // no mostrar los 1 para j
                if (NotEquals(b_abs, 1.0))
                    segunda += b_abs;

                segunda += "j";
            }

            // corregir los espacios
            if (primera != "" && segunda != "")
                signo = " " + (signo == "" ? "+" : signo) + " ";

            return primera + signo + segunda;
        }

        public bool esPuro()
        {
            return a == 0.0;
        }

        public static Complejo operator +(Complejo izq, Complejo der)
        {
            return new Complejo(izq.a + der.a, izq.b + der.b);
        }

        public static Complejo operator -(Complejo izq, Complejo der)
        {
            return new Complejo(izq.a - der.a, izq.b - der.b);
        }

        public static Complejo operator *(Complejo izq, Complejo der)
        {
            return new Complejo(izq.a * der.a - izq.b * der.b, izq.a * der.b + izq.b * der.a);
        }

        public static Complejo operator /(Complejo izq, Complejo der)
        {
            var b_conj = der.Conjugado();

            var numerador = izq * b_conj;

            var divisor = Math.Pow(der.a,2) + Math.Pow(der.b,2);
  
            return new Complejo (Math.Round(numerador.a / divisor,2), Math.Round(numerador.b / divisor,2));

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

            return Equals(this.a, c.a) && Equals(this.b, c.b);
        }
    }
}
