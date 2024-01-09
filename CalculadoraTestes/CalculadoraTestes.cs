using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementação _calc;


    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementação();
    }

    [Fact]
    public void DeveSomar()
    {
        //Arrenge
        int num1 = 10;
        int num2 = 20;

        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(30, resultado);

    }
    [Fact]
    public void ParOuImpar()
    {
        // Given
        int num = 60;
        // When
        bool resultado = _calc.EhPar(num);
        // Then
        Assert.True(resultado);
    }
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void TheoryParOuImpar(int num)
    {
        // Given
        // When
        bool resultado = _calc.EhPar(num);
        // Then
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]

    public void TheoryListaParOuImpar(int[] num)
    {
        //assert /act
        Assert.All(num, numeros => Assert.True(_calc.EhPar(numeros)));
    }


}