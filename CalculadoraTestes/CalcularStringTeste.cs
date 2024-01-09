using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalcularStringTeste
    {
        private CalculandoString _calc;
        public CalcularStringTeste()
        {
            _calc = new CalculandoString();
        }

        [Fact]
        public void ContarCaracter()
        {
            // Arrenge
            string parametro = "ola";
            // Act
            int resultado = _calc.ContarCaracter(parametro);
            // Assert
            Assert.Equal(3, resultado);
        }
    }

}