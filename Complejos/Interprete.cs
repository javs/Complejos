using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Complejos
{
    public class Interprete
    {
        public Complejo OperacionBasica(string opA, string op, string opB)
        {
            Complejo a = Complejo.Interpretar(opA);
            Complejo b = Complejo.Interpretar(opB);

            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ErrorDeSintaxisException(
                        string.Format("Operador \"{0}\" desconocido.", op));
            }
        }

        public Complejo OperacionPotencia(string potenciaOp, string potenciaGrado)
        {
            Complejo op = Complejo.Interpretar(potenciaOp);

            int grado;

            try
            {
                grado = int.Parse(potenciaGrado);
            }
            catch (Exception e)
            {
                throw new Exception("Grado: " + e.Message);
            }

            return op.Potencia(grado);
        }

        public List<Complejo> OperacionRaiz(string op, string raiz)
        {
            Complejo a = Complejo.Interpretar(op);

            int b;

            try
            {
                b = int.Parse(raiz);
            }
            catch (Exception e)
            {
                throw new Exception("Raiz: " + e.Message);
            }

            return a.Raiz(b);
        }

        public FuncionSinusoidal OperacionSumaDeFasores(string fasorA, string fasorB)
        {
            FuncionSinusoidal a = FuncionSinusoidal.Interpretar(fasorA);
            FuncionSinusoidal b = FuncionSinusoidal.Interpretar(fasorB);

            return a + b;
        }
    }
}
