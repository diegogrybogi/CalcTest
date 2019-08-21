using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcTest.Infraestructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosApplication _app;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public CalculaJurosController(ICalculaJurosApplication app)
        {
            this._app = app;
        }

        /// <summary>
        /// Calcula taxa de juros
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<double> Get(decimal valorInicial, int meses)
        {
            return await _app.CalcularJurosAsync(valorInicial, meses);
        }

        /// <summary>
        /// Retorna git url
        /// </summary>
        /// <returns></returns>
        [HttpGet("ShowMeTheCode")]
        public async Task<string> ShowMeTheCode()
        {
            return await Task.FromResult("https://github.com/diegogrybogi/CalcTest");
        }
    }
}
