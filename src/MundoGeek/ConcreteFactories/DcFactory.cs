using MundoGeek.AbstractFactories;
using MundoGeek.AbstractProducts;
using MundoGeek.Products;

namespace MundoGeek.ConcreteFactories
{
    public class DcFactory : ProductFactory
    {
        public override Heroi CriarHeroi()
        {
            return new HeroiDc();
        }

        public override Vilao CriarVilao()
        {
            return new VilaoDc();
        }
    }
}
