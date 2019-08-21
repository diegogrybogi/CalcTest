using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CalcTest.Infraestructure.Interfaces;

namespace CalcTest.Application.Applications
{
    public class TaxaJurosApplication : ITaxaJurosApplication
    {
        private const double Juros = 0.01;
        public async Task<double> GetTaxaJurosAsync()
        {
            return await Task.FromResult(Juros);
        }
    }
}
