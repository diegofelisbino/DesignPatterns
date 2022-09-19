using CambioVeiculo.Clients;
using CambioVeiculo.Domain.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CambioVeiculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("automatico")]
        public IActionResult ObterAutomatico([FromQuery] TipoProduto tipo)
        {
            var produto = ProductClient.CriarProductClient(tipo);

            var automaticos = produto.ObterAutomaticos();

            if (automaticos == null)
            {
                return BadRequest();
            }

            return Ok(automaticos);
        }


        [HttpGet("manual")]
        public IActionResult ObterManual([FromQuery] TipoProduto tipo)
        {
            var produto = ProductClient.CriarProductClient(tipo);

            var manuais = produto.ObterManuais();

            if (manuais == null)
            {
                return BadRequest();
            }

            return Ok(manuais);
        }

    }
}
