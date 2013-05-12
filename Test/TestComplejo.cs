using System;
using System.Collections.Generic;
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
        public void testParsear()
        {

            int extraido;
            Complejo resultado;

            // Forma binomica
            Assert.IsTrue(Complejo.Parsear("(1;1)", out resultado, out extraido));

            Assert.AreEqual(5, extraido);

            Assert.AreEqual(
                new Complejo(1, 1, Complejo.Forma.Binomica),
                resultado);

            // Forma binomica con signos
            Assert.IsTrue(Complejo.Parsear("(-1;3)", out resultado, out extraido));

            Assert.AreEqual(6, extraido);

            Assert.AreEqual(
                new Complejo(-1, 3, Complejo.Forma.Binomica),
                resultado);


            // Forma polar con sobras
            Assert.IsTrue(Complejo.Parsear("[1;1]asd", out resultado, out extraido));

            Assert.AreEqual(5, extraido);

            Assert.AreEqual(
                new Complejo(1, 1, Complejo.Forma.Polar),
                resultado);


            // Forma polar con pi y sobras
            Assert.IsTrue(Complejo.Parsear("[1;1pi][3;2pi]", out resultado, out extraido));

            Assert.AreEqual(7, extraido);

            Assert.AreEqual(
                new Complejo(1, 1 * Math.PI, Complejo.Forma.Polar),
                resultado);

            // Forma polar con pi, signos y decimales
            Assert.IsTrue(Complejo.Parsear("[-1.567;+5pi]", out resultado, out extraido));

            Assert.AreEqual(13, extraido);

            Assert.AreEqual(
                new Complejo(-1.567, 5 * Math.PI, Complejo.Forma.Polar),
                resultado);

            // Forma polar con pi, signos y decimales
            Assert.IsTrue(Complejo.Parsear("[5;pi]", out resultado, out extraido));

            Assert.AreEqual(6, extraido);

            Assert.AreEqual(
                new Complejo(5, Math.PI, Complejo.Forma.Polar),
                resultado);

            // Formas incorrecta
            Assert.IsFalse(Complejo.Parsear("[1-1]", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("(1;1]", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("1;1]", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("a(1;1)", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear(" (1;1)", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("[1.-3;1]", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("(-;1)", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("(1;)", out resultado, out extraido));
            Assert.IsFalse(Complejo.Parsear("[;1]", out resultado, out extraido));
        }
    }
}
