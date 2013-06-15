using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                fase_izq = fase_izq - Math.PI / 2;

            if (der.angulo == Angulo.Seno)
                fase_der = fase_der - Math.PI / 2;

            var fasor_izq = new Complejo(izq.amplitud, fase_izq, Complejo.Forma.Polar);
            var fasor_der = new Complejo(der.amplitud, fase_der, Complejo.Forma.Polar);

            var fasor_suma = fasor_izq + fasor_der;

            var fase_total = fasor_suma.b;

            if (angulo == Angulo.Seno)
                fase_total = fase_total + Math.PI / 2;

            return new FuncionSinusoidal(fasor_suma.a, angulo, izq.frecuencia, fase_total);
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

        public static FuncionSinusoidal Interpretar(string expresion)
        {
            const string NUMERO_DECIMAL = @"(?:([+-]?[\d]+[\.\,]?[\d]*))";

            expresion = Regex.Replace(expresion, @"\s+", string.Empty);

            Match m;
            // Evita el default que agrega "AllowThousands"
            NumberStyles style = NumberStyles.Float;

            m = Regex.Match(
                expresion,
                @"^" + NUMERO_DECIMAL + @"?(sin|cos)\s*\(" +
                NUMERO_DECIMAL + "t" + NUMERO_DECIMAL + @"?\)\s*$",
                RegexOptions.Compiled);

            if (m.Success)
            {
                double frecuencia = double.Parse(m.Groups[3].Value, style);

                double amplitud = m.Groups[1].Success
                    ? double.Parse(m.Groups[1].Value, style)
                    : 1;

                double fase = m.Groups[4].Success
                    ? double.Parse(m.Groups[4].Value, style)
                    : 0;

                FuncionSinusoidal.Angulo angulo;
                string angulo_texto = m.Groups[2].Value;

                if (angulo_texto == "sin")
                    angulo = Angulo.Seno;
                else if (angulo_texto == "cos")
                    angulo = Angulo.Coseno;
                else
                    throw new ErrorDeSintaxisException(
                        "Solo se esperan funciones sin o cos");

                return new FuncionSinusoidal(amplitud, angulo, frecuencia, fase);
            }

            throw new ErrorDeSintaxisException(
                "Se espera una funcion de la forma Asin(wt+o) o Acos(wt+o)");
        }
    }
}
