using NewTalents;
using System;
using Xunit;

namespace UnitTest1
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2024";
            Calculadora calc = new Calculadora(data);
            return calc;

        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        [InlineData(5, 5, 10)]
        public void TestSoma(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCakculadora = calc.soma(val1, val2);
            Assert.Equal( resultado, resultadoCakculadora);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(7, 5, 2)]
        [InlineData(7, 2, 5)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCakculadora = calc.subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCakculadora);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(5, 5, 25)]
        public void TestMultiplicacao(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCakculadora = calc.multiplicacao(val1, val2);
            Assert.Equal(resultado, resultadoCakculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        [InlineData(4, 2, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCakculadora = calc.dividir(val1, val2);
            Assert.Equal(resultado, resultadoCakculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.soma(1, 2);
            calc.soma(2, 8);
            calc.soma(3, 7);
            calc.soma(10, 10);
            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }





    }
}
