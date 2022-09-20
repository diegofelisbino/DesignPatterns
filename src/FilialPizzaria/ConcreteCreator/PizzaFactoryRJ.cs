using FilialPizzaria.ConcreteProduct;
using FilialPizzaria.Creator;
using FilialPizzaria.Product;

namespace FilialPizzaria.ConcreteCreator
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(SaborProduto tipo)
        {
            switch (tipo)
            {
                case SaborProduto.Calabresa:
                    return new PizzaCalabresaRJ();                    
                case SaborProduto.Mussarela:
                    return new PizzaMussarelaRJ();
                default:
                    throw new Exception("Not Found");
            }
        }
    }
}
