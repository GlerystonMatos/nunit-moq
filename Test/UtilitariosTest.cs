using Aplicacao;
using NUnit.Framework;
using System;

namespace Test
{
    public class UtilitariosTest
    {
        [Test]
        [TestCase(10, 20, 30, TestName = "A soma dos números 10 e 20 deve retornar 30")]
        [TestCase(5, 5, 10, TestName = "A soma dos números 05 e 05 deve retornar 10")]
        public void AoSomarDeveRetornarASomaDosNumeros(int valor01, int valor02, int resultado)
        {
            Assert.AreEqual(resultado, Utilitarios.Somar(valor01, valor02));
            Assert.IsTrue(Utilitarios.Somar(valor01, valor02) == resultado);
            Assert.NotZero(Utilitarios.Somar(valor01, valor02));
        }

        [Test]
        [TestCase(10, 20, 200)]
        [TestCase(2, 5, 10)]
        public void AoMultiplicarDeveRetornarAMultiplicacaoDosNumeros(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Multiplicar(valor01, valor02));

        [Test]
        [TestCase(20, 5, 15)]
        [TestCase(20, 10, 10)]
        public void AoSubtrairDeveRetornarASubitracaoDosNumeros(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Subtrair(valor01, valor02));

        [Test]
        [TestCase(10, 5, 2)]
        [TestCase(50, 10, 5)]
        public void AoDividirDeveRetornarADivisaoDosNumeros(int valor01, int valor02, int resultado)
            => Assert.AreEqual(resultado, Utilitarios.Dividir(valor01, valor02));

        [Test]
        [TestCase(10, 5)]
        public void AoRealizarADivisaoNaoDeveRetornarExercao(int valor01, int valor02)
            => Assert.DoesNotThrow(() => Utilitarios.Dividir(valor01, valor02));

        [Test]
        [TestCase(10, 0)]
        public void AoRealizarADivisaoDeveRetornarExercao(int valor01, int valor02)
        {
            DivideByZeroException exception = Assert.Throws<DivideByZeroException>(() => Utilitarios.Dividir(valor01, valor02));
            Assert.That(exception.Message, Is.EqualTo("Attempted to divide by zero."));
        }
    }
}