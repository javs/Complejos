using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    public class Complejo
    {
        public enum Forma
        {
            Binomica,
            //Polar,
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
        }

        public override string ToString()
        {
            if (a == 0.0 && b == 0.0)
                return "0";

            string primera = "";
            string signo = "";
            string segunda = "";

            if (a != 0.0)
                primera += a;

            if (b != 0.0)
            {
                if (b < 0.0)
                    signo = "-";

                double b_abs = Math.Abs(b);

                // no mostrar los 1 para j
                if (b_abs != 1.0)
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

        public override bool Equals(object otro)
        {
            if (otro == null)
                return false;

            Complejo c = otro as Complejo;

            if ((System.Object)c == null)
                return false;

            return this.a == c.a && this.b == c.b;
        }
    }
}
