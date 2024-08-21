using Calculadora.Models;

namespace CalculadoraTests;

public class UnitTest1
{
    CalculadoraP calc = new CalculadoraP("21/08/2024");
  
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        //Act
        var resultadoCalculadora = calc.Somar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        //Act
        var resultadoCalculadora = calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        //Act
        var resultadoCalculadora = calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 8, 2)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        //Act
        var resultadoCalculadora = calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDividirDividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        calc.Somar(1, 2);
        calc.Somar(2, 3);
        calc.Somar(3, 4);
        calc.Somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}