using MundoGeek.AbstractProducts;

namespace MundoGeek.Products
{
    public class HeroiDc : Heroi
    {
        public HeroiDc() : base (TipoProduto.Dc)
        {

        }

        public override List<Heroi> BuscarHerois()
        {
            return new List<Heroi>()
           {
               new HeroiDc(){Name = "Super Homem"},
               new HeroiDc(){Name = "Flash"},
               new HeroiDc(){Name = "Batman"},
               new HeroiDc(){Name = "Mulher Maravilha"},
               new HeroiDc(){Name = "Cyborg"},
               new HeroiDc(){Name = "Lanterna Verde"},

           };
        }
    }

    
}
