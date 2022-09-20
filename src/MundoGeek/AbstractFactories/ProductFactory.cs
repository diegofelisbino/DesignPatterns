using MundoGeek.AbstractProducts;

namespace MundoGeek.AbstractFactories
{
    public abstract class ProductFactory
    {
        public abstract Heroi CriarHeroi();
        public abstract Vilao CriarVilao();
    }
}
