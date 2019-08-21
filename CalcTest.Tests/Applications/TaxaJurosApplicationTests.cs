using CalcTest.Application.Applications;
using CalcTest.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcTest.Tests.Applications
{
    
    public class TaxaJurosApplicationTests
    {
        private readonly ITaxaJurosApplication _app;
        public TaxaJurosApplicationTests()
        {
            _app = new TaxaJurosApplication();
        }

        [Fact]
        public async void ShouldReturnValueWithSucess()
        {
            
            var total = 0.01;
            var result = await _app.GetTaxaJurosAsync();

            Assert.Equal(result, total);
        }
    }
}
