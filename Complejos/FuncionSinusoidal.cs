using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    public class FuncionSinusoidal
    {
        public const double PI_2 = Math.PI * 2;
        public const double Epsilon = 1E-13;

        public enum Angulo
        {
            Seno,
            Coseno,
        }

        public readonly double amplitud;
        public readonly Angulo angulo;
        public readonly double frecuencia;
        public readonly double fase;
        public int precision { get; set; }


        public FuncionSinusoidal(double amplitud = 1.0, Angulo angulo = Angulo.Coseno,
            double frecuencia = 1.0, double fase = 0.0)
        {
            this.amplitud = amplitud;
            this.frecuencia = frecuencia;
            this.fase = fase;
            this.angulo = angulo;
            this.precision = 2;

            if (amplitud < 0)
                throw new Exception("El valor de la amplitud no puede ser menor que cero");

        }

        public static FuncionSinusoidal operator +(FuncionSinusoidal izq, FuncionSinusoidal der)
        {

            var fase_izq = izq.fase;
            var fase_der = der.fase;
            var angulo = Angulo.Coseno;

            if (Math.Abs(izq.frecuencia - der.frecuencia) >= Epsilon)
                throw new Exception("No se pueden sumar funciones sinusoidales cuya frecuencia sea diferente");

            if (izq.angulo == Angulo.Seno && der.angulo == Angulo.Seno)
                angulo = Angulo.Seno;

            if (izq.angulo == Angulo.Seno)
                fase_izq = fase_izq + Math.PI / 2;

            if (der.angulo == Angulo.Seno)
                fase_der = fase_der + Math.PI / 2;

            var amplitud_total = Math.Sqrt(
                Math.Pow(izq.amplitud, 2) +
                Math.Pow(der.amplitud, 2) +
                2 * izq.amplitud * der.amplitud * Math.Cos(fase_izq - fase_der));

            var fase_total = Math.Atan(
                (izq.amplitud * Math.Sin(fase_izq) + der.amplitud * Math.Sin(fase_der))
                /
                (izq.amplitud * Math.Cos(fase_izq) + der.amplitud * Math.Cos(fase_der)));

            if (angulo == Angulo.Seno)
                fase_total = fase_total - Math.PI / 2;

            return new FuncionSinusoidal(amplitud_total, angulo, izq.frecuencia, fase_total);
        }

        public override string ToString()
        {
            var angulo = "cos";

            if (this.angulo == Angulo.Seno)
                angulo = "sin";

            var fase = "";

            if (!this.fase.Equals(0.0))
            {
                if (this.fase > 0)
                    fase += "+";
                fase += string.Format("{0}pi", Math.Round(this.fase / Math.PI, this.precision));
            }

            return string.Format("{0}{1}({2}t{3})",
                Math.Round(this.amplitud, this.precision),
                angulo,
                Math.Round(this.frecuencia, this.precision),
                fase);
        }
    }
}
