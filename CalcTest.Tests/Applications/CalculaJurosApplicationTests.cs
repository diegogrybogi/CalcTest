using System;
using System.Collections.Generic;
using System.Text;
using CalcTest.Application.Applications;
using CalcTest.Infraestructure.Interfaces;
using Xunit;

namespace CalcTest.Tests.Applications
{
    
    public class CalculaJurosApplicationTests
    {
        private readonly ICalculaJurosApplication _app;
        public CalculaJurosApplicationTests()
        {
            _app = new CalculaJurosApplication(); 
        }

        [Fact]
        public async void ShouldCalcWithSucess()
        {


            var valorInicial = 100;
            var meses = 5;
            var total = 105.1;

            var result = await _app.CalcularJurosAsync(valorInicial, meses);

            Assert.Equal(result, total);
        }
    }
}
