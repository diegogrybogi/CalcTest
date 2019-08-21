using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CalcTest.Infraestructure.Helpers;
using CalcTest.Infraestructure.Interfaces;

namespace CalcTest.Application.Applications
{
    public class CalculaJurosApplication : ICalculaJurosApplication
    {
       
        public async Task<double> CalcularJurosAsync(decimal valorInicial, int meses)
        {
            var taxa = await HttpHelper.Get<double>($"/api/taxajuros");
            var valorFinal = Math.Round(((double)valorInicial * Math.Pow((1 + taxa), meses)), 2);
            return await Task.FromResult(valorFinal);
        }     
    }
}
