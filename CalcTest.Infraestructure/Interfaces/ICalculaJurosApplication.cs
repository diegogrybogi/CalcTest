using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest.Infraestructure.Interfaces
{
    public interface ICalculaJurosApplication
    {
        Task<double> CalcularJurosAsync(decimal valorInicial, int meses);
    }
}
