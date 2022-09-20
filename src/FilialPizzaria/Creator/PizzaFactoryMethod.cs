using FilialPizzaria.Product;

namespace FilialPizzaria.Creator
{
    public abstract class PizzaFactoryMethod
    {
        public abstract Pizza CriarPizza(SaborProduto tipo);

        public Pizza MontarPizza(SaborProduto tipo)
        {
            var pizza = CriarPizza(tipo);
            return pizza;
        }
    }
}
