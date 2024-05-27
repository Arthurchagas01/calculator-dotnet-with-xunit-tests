using CalculadoraImp.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = construirClasse();
        // Act
        int resultadoCalculadora = calc.somar(val1, val2);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = construirClasse();
        // Act
        int resultadoCalculadora = calc.subtrair(val1, val2);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = construirClasse();
        // Act
        int resultadoCalculadora = calc.multiplicar(val1, val2);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = construirClasse();
        // Act
        int resultadoCalculadora = calc.dividir(val1, val2);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }

    [Fact]
        public void TesteDivisaoPorZero()
    {
        // Arrange
        Calculadora calc = construirClasse();

        // Assert
        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );

    }

    [Fact]
        public void TestarHistorico()
    {
        // Arrange
        Calculadora calc = construirClasse();
        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 2);

        // Act
        var lista = calc.historico();
        // Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }

}