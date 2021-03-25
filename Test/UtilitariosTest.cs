using Aplicacao;
using NUnit.Framework;
using System;

namespace Test
{
    public class UtilitariosTest
    {
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        public void SomarTest(int valor01, int valor02, int resultado)
        {
            Assert.AreEqual(resultado, Utilitarios.Somar(valor01, valor02));
            Assert.IsTrue(Utilitarios.Somar(valor01, valor02) == resultado);
            Assert.NotZero(Utilitarios.Somar(valor01, valor02));
        }

        [Test]
        [TestCase(10, 20, 200)]
        [TestCase(2, 5, 10)]
        public void MultiplicarTest(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Multiplicar(valor01, valor02));

        [Test]
        [TestCase(20, 5, 15)]
        [TestCase(20, 10, 10)]
        public void SubtrairTest(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Subtrair(valor01, valor02));

        [Test]
        [TestCase(10, 5, 2)]
        [TestCase(50, 10, 5)]
        public void DividirTest(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Dividir(valor01, valor02));

        [Test]
        [TestCase(10, 5)]
        public void DividirTestDoesNotThrow(int valor01, int valor02)
            => Assert.DoesNotThrow(() => Utilitarios.Dividir(valor01, valor02));

        [Test]
        [TestCase(10, 0)]
        public void DividirTestThrows(int valor01, int valor02)
        {
            DivideByZeroException exception = Assert.Throws<DivideByZeroException>(() => Utilitarios.Dividir(valor01, valor02));
            Assert.That(exception.Message, Is.EqualTo("Attempted to divide by zero."));
        }
    }
}