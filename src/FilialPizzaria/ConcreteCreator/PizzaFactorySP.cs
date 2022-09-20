using FilialPizzaria.ConcreteProduct;
using FilialPizzaria.Creator;
using FilialPizzaria.Product;

namespace FilialPizzaria.ConcreteCreator
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(SaborProduto tipo)
        {
            switch (tipo)
            {
                case SaborProduto.Calabresa:
                    return new PizzaCalabresaSP();
                case SaborProduto.Mussarela:
                    return new PizzaMussarelaSP();
                default:
                    throw new Exception("Not Found");
            }
        }
    }
}
