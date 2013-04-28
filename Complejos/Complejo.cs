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
        

        public Complejo(double real = 0, double imaginario = 1,
            Forma forma = Forma.Binomica)
        {
            this.a = real;
            this.b = imaginario;
            this.forma = forma;
        }

        public override string ToString()
        {
            string r = "";

            if (esPuro)

            /*if (a != 0.0)
                r += a;

            if (b != 0.0)
            {
                if (r != "")
                    r += " + ";

                if (b != 1.0)
                    r += b;

                r += "j";
            }*/

            if (r == "")
                r = "0";

            return r;
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
