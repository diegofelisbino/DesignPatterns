using FilialPizzaria.ConcreteCreator;
using FilialPizzaria.Creator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilialPizzaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterPizza([FromQuery] Filial filial, [FromQuery] SaborProduto tipo)
        {
            PizzaFactoryMethod pizzaria;

            switch (filial)
            {
                case Filial.SP:
                    pizzaria = new PizzaFactorySP();
                    break;
                case Filial.RJ:
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    pizzaria = null;
                    break;
            }

            if (pizzaria == null)
            {
                return BadRequest();
            }
            var pizza = pizzaria.MontarPizza(tipo);

            return Ok(pizza);

        }
    }
}
