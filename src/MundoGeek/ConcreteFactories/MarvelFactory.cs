using MundoGeek.AbstractFactories;
using MundoGeek.AbstractProducts;
using MundoGeek.Products;

namespace MundoGeek.ConcreteFactories
{
    public class MarvelFactory : ProductFactory
    {
        public override Heroi CriarHeroi()
        {
            return new HeroiMarvel();
        }

        public override Vilao CriarVilao()
        {
            return new VilaoMarvel();
        }
    }


}
