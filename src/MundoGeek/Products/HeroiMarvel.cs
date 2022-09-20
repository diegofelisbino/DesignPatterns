using MundoGeek.AbstractProducts;

namespace MundoGeek.Products
{
    public class HeroiMarvel : Heroi
    {

        public HeroiMarvel() : base (TipoProduto.Marvel)
        {

        }
        public override List<Heroi> BuscarHerois()
        {
            return new List<Heroi>()
            {
                new HeroiMarvel(){ Name = "Homem de Ferro"},
                new HeroiMarvel(){ Name = "Homem Aranha"},
                new HeroiMarvel(){ Name = "Hulk"},
                new HeroiMarvel(){ Name = "Woverine"},
                new HeroiMarvel(){ Name = "Cap. América"},
                new HeroiMarvel(){ Name = "Thor"}
            };
        }
    }

    
}
