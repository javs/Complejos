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
        List<Complejo> binomico;

        [SetUp]
        public void Init()
        {
            binomico = new List<Complejo>();

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
        }

        [Test]
        public void testConstructorBinomico()
        {
            Assert.AreEqual(binomico[0].a,  0.0); Assert.AreEqual(binomico[0].b,  1.0);
            Assert.AreEqual(binomico[1].a,  1.0); Assert.AreEqual(binomico[1].b,  1.0);
            Assert.AreEqual(binomico[11].a, 6.0); Assert.AreEqual(binomico[11].b, 2.9);
        }

        [Test]
        public void testToString()
        {
            Assert.AreEqual(binomico[0].ToString(),  "j");
            Assert.AreEqual(binomico[1].ToString(),  "1 + j");
            Assert.AreEqual(binomico[2].ToString(),  "1");
            Assert.AreEqual(binomico[3].ToString(),      "j");
            Assert.AreEqual(binomico[4].ToString(),  "2");
            Assert.AreEqual(binomico[5].ToString(),     "2j");
            Assert.AreEqual(binomico[6].ToString(),  "1 + j");
            Assert.AreEqual(binomico[7].ToString(),  "2 + 2j");
            Assert.AreEqual(binomico[8].ToString(),  "1 + 2" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "1j");
            Assert.AreEqual(binomico[9].ToString(),  "2 + j");
            Assert.AreEqual(binomico[10].ToString(), "5" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "2 + 5j");
            Assert.AreEqual(binomico[11].ToString(), "6 + 2" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "9j");
            Assert.AreEqual(binomico[12].ToString(), "0");
            Assert.AreEqual(binomico[13].ToString(), "-1 - j");
            Assert.AreEqual(binomico[14].ToString(), "-1");
            Assert.AreEqual(binomico[15].ToString(),     "-j");
        }

        [Test]
        public void testSumaYResta()
        {
            Assert.AreEqual(binomico[2] + binomico[3], binomico[6]);
            Assert.AreEqual(binomico[7] - binomico[7], binomico[12]);
            Assert.AreEqual(binomico[9] - binomico[6], binomico[2]);
        }

        [Test]
        public void testMultiplicacion()
        {
            Assert.AreEqual(new Complejo(0.0, 0.0) * new Complejo(1.0, 0.0), new Complejo(0.0, 0.0));
            Assert.AreEqual(new Complejo(0.0, 0.0) * new Complejo(0.0, 1.0), new Complejo(0.0, 0.0));

            Assert.AreEqual(new Complejo(0.0, 2.0) * new Complejo(2.0, 2.0), new Complejo(-4.0, 4.0));
            Assert.AreEqual(new Complejo(-1.0, 2.0) * new Complejo(-2.0, -1.0), new Complejo(4.0, -3.0));
        }

        [Test]
        public void testComplemento()
        {
            Assert.AreEqual(new Complejo(0.0, 0.0).Conjugado(), new Complejo(0.0, 0.0));
            Assert.AreEqual(new Complejo(1.0, 1.0).Conjugado(), new Complejo(1.0, -1.0));
            Assert.AreEqual(new Complejo(-1.0, 0.0).Conjugado(), new Complejo(-1.0, 0.0));
            Assert.AreEqual(new Complejo(-1.0, -4.0).Conjugado(), new Complejo(-1.0, 4.0));
        }

        [Test]
        public void testDivision()
        {
            Assert.AreEqual(new Complejo(0.0, 0.0) / new Complejo(1.0, 0.0), new Complejo(0.0, 0.0));
            Assert.AreEqual(new Complejo(0.0, 0.0) / new Complejo(0.0, 1.0), new Complejo(0.0, 0.0));

            {
                Complejo nan = new Complejo(1.0, 1.0) / new Complejo(0.0, 0.0);

                Assert.IsNaN(nan.a);
                Assert.IsNaN(nan.b);
            }

            Assert.AreEqual(new Complejo(0.0, 2.0) / new Complejo(2.0, 2.0), new Complejo(0.5, 0.5));
            Assert.AreEqual(new Complejo(-1.0, 2.0) / new Complejo(-2.0, -1.0), new Complejo(0.0, -1.0));
        }
    }
}
