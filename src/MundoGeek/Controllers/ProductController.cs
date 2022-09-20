using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundoGeek.AbstractProducts;

namespace MundoGeek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet("heroi")]
        public IActionResult BuscarHeroi([FromQuery] TipoProduto tipoProduto)
        {
            var produto = Clients.ProductClient.CriarProductClient(tipoProduto);

            var herois = produto.BuscarHerois();

            if (herois == null)
            {
                return BadRequest();
            }

            return Ok(herois);

            
        }


        [HttpGet("vilao")]
        public IActionResult BuscarVilao([FromQuery] TipoProduto tipoProduto)
        {
            var produto = Clients.ProductClient.CriarProductClient(tipoProduto);

            var viloes = produto.BuscarViloes();

            if (viloes == null)
            {
                return BadRequest();
            }

            return Ok(viloes);


        }
    }
}
