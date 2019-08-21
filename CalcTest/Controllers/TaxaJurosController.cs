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
    public class TaxaJurosController : ControllerBase
    {

        private readonly ITaxaJurosApplication _app;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public TaxaJurosController(ITaxaJurosApplication app)
        {
            this._app = app;
        }

        /// <summary>
        /// Retorna taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<double> Get()
        {
            return await _app.GetTaxaJurosAsync();
        }       
    }
}
