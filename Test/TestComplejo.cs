using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Complejos.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TestComplejo
    {
        string s;

        List<Complejo> binomico = new List<Complejo>();
        List<Complejo> polar = new List<Complejo>();

        [SetUp]
        public void Init()
        {
            // Algunos numeros complejos de prueba en forma binomica
            binomico.Add(new Complejo());           // 0
            binomico.Add(new Complejo(1.0));        // 1
            binomico.Add(new Complejo(1.0, 0.0));   // 2
            binomico.Add(new Complejo(0.0, 1.0));   // 3
            binomico.Add(new Complejo(2.0, 0.0));   // 4
            binomico.Add(new Complejo(0.0, 2.0));   // 5
            binomico.Add(new Complejo(1.0, 1.0));   // 6
            binomico.Add(new Complejo(2.0, 2.0));   // 7
            binomico.Add(new Complejo(1.0, 2.1));   // 8
            binomico.Add(new Complejo(2.0, 1.0));   // 9
            binomico.Add(new Complejo(5.2, 5.0));   // 10
            binomico.Add(new Complejo(6.0, 2.9));   // 11
            binomico.Add(new Complejo(0.0, 0.0));   // 12
            binomico.Add(new Complejo(-1.0, -1.0)); // 13
            binomico.Add(new Complejo(-1.0, 0.0));  // 14
            binomico.Add(new Complejo(0.0, -1.0));  // 15

            // forma polar
            polar.Add(new Complejo(1.0, 0.0, Complejo.Forma.Polar));
            polar.Add(new Complejo(1.0, 1.0 * Math.PI, Complejo.Forma.Polar));
            polar.Add(new Complejo(1.0, 1.0 * Math.PI, Complejo.Forma.Polar));

            s = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
        }

        [Test]
        public void testConstructorBinomico()
        {
            Assert.AreEqual(0.0, binomico[0].a);    Assert.AreEqual(1.0, binomico[0].b);
            Assert.AreEqual(1.0, binomico[1].a);    Assert.AreEqual(1.0, binomico[1].b);
            Assert.AreEqual(6.0, binomico[11].a);   Assert.AreEqual(2.9, binomico[11].b);
        }

        [Test]
        public void testConstructorPolar()
        {
            Assert.AreEqual(1.0,            new Complejo(1.0, 1.0, Complejo.Forma.Polar).a);
            Assert.AreEqual(Math.PI,        new Complejo(1.0, Math.PI, Complejo.Forma.Polar).b);

            Assert.That(new Complejo(1.0, Math.PI * 3, Complejo.Forma.Polar).b,
                Is.EqualTo(Math.PI)
                    .Within(Complejo.Epsilon));

            Assert.That(new Complejo(1.0, Math.PI * 8.25, Complejo.Forma.Polar).b,
                Is.EqualTo(0.25 * Math.PI)
                    .Within(Complejo.Epsilon));

            Assert.That(new Complejo(1.0, Math.PI * -5.5, Complejo.Forma.Polar).b,
                Is.EqualTo(0.5 * Math.PI)
                    .Within(Complejo.Epsilon));           
        }

        [Test]
        public void testToString()
        {
            
            Assert.AreEqual(    "j",            binomico[0].ToString());
            Assert.AreEqual("1 + j",            binomico[1].ToString());
            Assert.AreEqual("1",                binomico[2].ToString());
            Assert.AreEqual(    "j",            binomico[3].ToString());
            Assert.AreEqual("2",                binomico[4].ToString());
            Assert.AreEqual(   "2j",            binomico[5].ToString());
            Assert.AreEqual("1 + j",            binomico[6].ToString());
            Assert.AreEqual("2 + 2j",           binomico[7].ToString());
            Assert.AreEqual("1 + 2" + s + "1j", binomico[8].ToString());
            Assert.AreEqual("2 + j",            binomico[9].ToString());
            Assert.AreEqual("5" + s + "2 + 5j", binomico[10].ToString());
            Assert.AreEqual("6 + 2" + s + "9j", binomico[11].ToString());
            Assert.AreEqual("0",                binomico[12].ToString());
            Assert.AreEqual("-1 - j",           binomico[13].ToString());
            Assert.AreEqual("-1",               binomico[14].ToString());
            Assert.AreEqual(    "-j",           binomico[15].ToString());

            double dentroDelError = Double.Epsilon; // el error de Double es mas chico que nuestro error

            Assert.AreEqual("0", new Complejo(dentroDelError, dentroDelError).ToString());
            Assert.AreEqual("1", new Complejo(1 + dentroDelError, dentroDelError).ToString());
            Assert.AreEqual("j", new Complejo(dentroDelError, 1 + dentroDelError).ToString());

            Assert.AreEqual("[1;0]",            polar[0].ToString());
            Assert.AreEqual("[1;1pi]",          polar[1].ToString());
        }

        [Test]
        public void testIgualdad()
        {
            Assert.AreEqual(new Complejo(1, 1), new Complejo(1, 1));
            Assert.AreNotEqual(new Complejo(1, 1), new Complejo(1, 2));

            Assert.AreEqual(new Complejo(1, 1, Complejo.Forma.Polar), new Complejo(1, 1, Complejo.Forma.Polar));
            Assert.AreNotEqual(new Complejo(1, 1, Complejo.Forma.Polar), new Complejo(1, 2, Complejo.Forma.Polar));
            Assert.AreNotEqual(new Complejo(2, 1, Complejo.Forma.Polar), new Complejo(1, 2, Complejo.Forma.Polar));

            Assert.AreNotEqual(new Complejo(1, 1, Complejo.Forma.Binomica), new Complejo(1, 1, Complejo.Forma.Polar));

            Assert.AreEqual(
                new Complejo(1, Math.PI / 4, Complejo.Forma.Polar),
                new Complejo(Math.Sqrt(2) / 2, Math.Sqrt(2) / 2, Complejo.Forma.Binomica));    
        }

        [Test]
        public void testSumaYResta()
        {
            Assert.AreEqual(binomico[2] + binomico[3], binomico[6]);
            Assert.AreEqual(binomico[7] - binomico[7], binomico[12]);
            Assert.AreEqual(binomico[9] - binomico[6], binomico[2]);

            {
                var uno = new Complejo(Math.Sqrt(2) / 2, Math.Sqrt(2) / 2, Complejo.Forma.Binomica);
                var otro_igual = new Complejo(1, Math.PI / 4, Complejo.Forma.Polar);

                Assert.AreEqual(new Complejo(0, 0), uno - otro_igual);
            }
        }

        [Test]
        public void testMultiplicacion()
        {
            Assert.AreEqual(new Complejo( 0.0,  0.0), new Complejo( 0.0, 0.0) * new Complejo( 1.0,  0.0));
            Assert.AreEqual(new Complejo( 0.0,  0.0), new Complejo( 0.0, 0.0) * new Complejo( 0.0,  1.0));

            Assert.AreEqual(new Complejo(-4.0,  4.0), new Complejo( 0.0, 2.0) * new Complejo( 2.0,  2.0));
            Assert.AreEqual(new Complejo( 4.0, -3.0), new Complejo(-1.0, 2.0) * new Complejo(-2.0, -1.0));

            Assert.That(
                new Complejo(1.0, Math.PI / 4.0, Complejo.Forma.Polar) *
                new Complejo(2.0, Math.PI / 2.0, Complejo.Forma.Polar),
                    Is.EqualTo(new Complejo(2.0, Math.PI * 0.75, Complejo.Forma.Polar))
                        .Within(Complejo.Epsilon));
        }

        [Test]
        public void testConjugado()
        {
            Assert.AreEqual(new Complejo(0.0,  0.0), new Complejo(0.0, 0.0).Conjugado());
            Assert.AreEqual(new Complejo(1.0, -1.0), new Complejo(1.0, 1.0).Conjugado());
            Assert.AreEqual(new Complejo(-1.0, 0.0), new Complejo(-1.0, 0.0).Conjugado());
            Assert.AreEqual(new Complejo(-1.0, 4.0), new Complejo(-1.0, -4.0).Conjugado());

            Assert.AreEqual(
                new Complejo(1.0, 1.75 * Math.PI, Complejo.Forma.Polar),
                new Complejo(1.0, Math.PI / 4.0, Complejo.Forma.Polar).Conjugado());

            Assert.AreEqual(
                new Complejo(2.0, 0.75 * Math.PI, Complejo.Forma.Polar),
                new Complejo(2.0, 1.25 * Math.PI, Complejo.Forma.Polar).Conjugado());

            Assert.AreEqual(
                new Complejo(-2.0, 0.25 * Math.PI, Complejo.Forma.Polar),
                new Complejo(-2.0, 1.75 * Math.PI, Complejo.Forma.Polar).Conjugado());
        }

        [Test]
        public void testDivision()
        {
            Assert.AreEqual(new Complejo(0.0, 0.0), new Complejo(0.0, 0.0) / new Complejo(1.0, 0.0));
            Assert.AreEqual(new Complejo(0.0, 0.0), new Complejo(0.0, 0.0) / new Complejo(0.0, 1.0));

            {
                Complejo nan = new Complejo(1.0, 1.0) / new Complejo(0.0, 0.0);

                Assert.IsNaN(nan.a);
                Assert.IsNaN(nan.b);
            }

            Assert.AreEqual(new Complejo(0.5,  0.5), new Complejo(0.0, 2.0)  / new Complejo(2.0, 2.0));
            Assert.AreEqual(new Complejo(0.0, -1.0), new Complejo(-1.0, 2.0) / new Complejo(-2.0, -1.0));

            Assert.That(
                new Complejo(1.0, Math.PI / 4.0, Complejo.Forma.Polar) /
                new Complejo(2.0, Math.PI / 2.0, Complejo.Forma.Polar),
                    Is.EqualTo(new Complejo(0.5, Math.PI * 1.75, Complejo.Forma.Polar))
                        .Within(Complejo.Epsilon));
        }

        [Test]
        public void testToPolar()
        {
            Assert.AreEqual(
                new Complejo(1, Math.PI / 4, Complejo.Forma.Polar),
                new Complejo(Math.Sqrt(2) / 2, Math.Sqrt(2) / 2, Complejo.Forma.Binomica)
                    .Convertir(Complejo.Forma.Polar));
        }

        [Test]
        public void testToBinomica()
        {
            Assert.AreEqual(
                new Complejo(Math.Sqrt(2) / 2, Math.Sqrt(2) / 2, Complejo.Forma.Binomica),
                new Complejo(1, Math.PI / 4, Complejo.Forma.Polar).Convertir(Complejo.Forma.Binomica));
        }

        [Test]
        public void testPotencia()
        {
            Assert.AreEqual(
                new Complejo(2, Math.PI, Complejo.Forma.Polar).Potencia(2),
                new Complejo(4, 2 * Math.PI, Complejo.Forma.Polar));

            Assert.AreEqual(
                new Complejo(1, 2, Complejo.Forma.Binomica).Potencia(2),
                new Complejo(-3, 4, Complejo.Forma.Binomica));

            Assert.AreEqual(
                new Complejo(1, 2, Complejo.Forma.Binomica).Potencia(0),
                new Complejo(1, 0, Complejo.Forma.Binomica));

            Assert.AreEqual(
                new Complejo(Math.Sqrt(2) / 2, Math.Sqrt(2) / 2, Complejo.Forma.Binomica).Potencia(2),
                new Complejo(1, Math.PI / 4, Complejo.Forma.Polar).Potencia(2));
        }

        [Test]
        public void testRaiz()
        {
            List<Complejo> raices = new List<Complejo>();

            // raices de el complejo ( 3 , 4 )
            raices.Add(new Complejo(2,1,Complejo.Forma.Binomica));
            raices.Add(new Complejo(-2,-1,Complejo.Forma.Binomica));

            Assert.AreEqual(
                raices,
                new Complejo(3, 4, Complejo.Forma.Binomica).Raiz(2));

            raices.Clear();

            // raices de el complejo [ 8 ; 3/2 pi ]
            raices.Add(new Complejo(2, Math.PI / 2, Complejo.Forma.Polar));
            raices.Add(new Complejo(2, Math.PI * 7 / 6, Complejo.Forma.Polar));
            raices.Add(new Complejo(2, Math.PI * 11 / 6, Complejo.Forma.Polar));

            Assert.AreEqual(
                raices,
                new Complejo(8, Math.PI * 3 / 2, Complejo.Forma.Polar).Raiz(3));

            Assert.AreEqual(
                new Complejo(0,-8,Complejo.Forma.Binomica).Raiz(3),
                new Complejo(8, Math.PI * 3 / 2, Complejo.Forma.Polar).Raiz(3));

        }

        [Test]
        public void testRaizPrimitiva()
        {
            List<Complejo> raices_primitivas = new List<Complejo>();

            Complejo unidad = binomico[2];

            // raices primitivas para n = 4
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(0, 1, Complejo.Forma.Binomica));
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(0, -1, Complejo.Forma.Binomica));

            Assert.AreEqual(
                raices_primitivas,
                unidad.Primitivas(4));

            raices_primitivas.Clear();

            // raices primitivas para n = 8
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(1, Math.PI * 1 / 4, Complejo.Forma.Polar));
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(1, Math.PI * 3 / 4, Complejo.Forma.Polar));
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(1, Math.PI * 5 / 4, Complejo.Forma.Polar));
            raices_primitivas.Add(null);
            raices_primitivas.Add(new Complejo(1, Math.PI * 7 / 4, Complejo.Forma.Polar));

            Assert.AreEqual(
                raices_primitivas,
                unidad.Convertir(Complejo.Forma.Polar).Primitivas(8));

            raices_primitivas.Clear();

            raices_primitivas = unidad.Raiz(30);

            // saco todas las raices que no son primitivas
            raices_primitivas[0]  = null;
            raices_primitivas[2]  = null;
            raices_primitivas[3]  = null;
            raices_primitivas[4]  = null;
            raices_primitivas[5]  = null;
            raices_primitivas[6]  = null;
            raices_primitivas[8]  = null;
            raices_primitivas[9]  = null;
            raices_primitivas[10] = null;
            raices_primitivas[12] = null;
            raices_primitivas[14] = null;
            raices_primitivas[15] = null;
            raices_primitivas[16] = null;
            raices_primitivas[18] = null;
            raices_primitivas[20] = null;
            raices_primitivas[21] = null;
            raices_primitivas[22] = null;
            raices_primitivas[24] = null;
            raices_primitivas[25] = null;
            raices_primitivas[26] = null;
            raices_primitivas[27] = null;
            raices_primitivas[28] = null;

            Assert.AreEqual(
                raices_primitivas,
                unidad.Primitivas(30));
        }

        [Test]
        public void testParsear()
        {
            // Forma binomica
            Assert.AreEqual(
                Complejo.Interpretar("(1;1)"),
                new Complejo(1, 1, Complejo.Forma.Binomica));

            // Forma binomica con signos
            Assert.AreEqual(
                Complejo.Interpretar("(-1;3)"),
                new Complejo(-1, 3, Complejo.Forma.Binomica));
            
            // Forma polar con sobras
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("[1;1]asd"));

            // Forma polar con pi y sobras
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("[1;1pi][3;2pi]"));

            // Forma polar con pi, signos y decimales
            Assert.AreEqual(
                Complejo.Interpretar("[-1" + s + "567;+5pi]"),
                new Complejo(-1.567, 5 * Math.PI, Complejo.Forma.Polar));

            // Forma polar con pi, signos y decimales
            Assert.AreEqual(
                Complejo.Interpretar("[5;pi]"),
                new Complejo(5, Math.PI, Complejo.Forma.Polar));

            // Testear lo opuesto al separador decimal actual
            if (s == ".")
                Assert.Throws<FormatException>(() => Complejo.Interpretar("(1,2;3,4)"));
            else
                Assert.Throws<FormatException>(() => Complejo.Interpretar("(1.2;3.4)"));

            // Formas incorrectas
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("[1-1]"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("(1;1]"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("1;1]"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("a(1;1)"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar(" (1;1)"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("[1.-3;1]"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("(-;1)"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("(1;)"));
            Assert.Throws<ErrorDeSintaxisException>(() => Complejo.Interpretar("[;1]"));
        }
    }
}
