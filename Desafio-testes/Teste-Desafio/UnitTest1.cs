using Desafio_testes;
namespace Teste_Desafio
{
    public class UnitTest1
    {

        public calculadora construiClasse()
        {
            string data = "02/02/2020";
            calculadora calc = new calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData (1 ,2 ,3)]
        [InlineData (4 ,5 ,9)]
        public void TesteSomar(int val1, int val2, int resulado)
        {
            calculadora calc = construiClasse();
            
            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resulado,resultadoCalculadora);  
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resulado)
        {
            calculadora calc = construiClasse();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resulado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resulado)
        {
            calculadora calc = construiClasse();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resulado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resulado)
        {
            calculadora calc = construiClasse();   

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resulado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            calculadora calc = construiClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)

            );
        }

        [Fact]
        public void TestarHistorico()
        {
            calculadora calc = construiClasse();

            calc.somar(1, 2);
            calc.somar(3, 4);
            calc.somar(5, 2);
            calc.somar(8, 5);

            var lista = calc.historico();
           
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count()); 

        }
    }
}