using MundoGeek.AbstractProducts;

namespace MundoGeek.Products
{
    public class VilaoMarvel : Vilao
    {
        public VilaoMarvel() : base(TipoProduto.Marvel)
        {

        }
        public override List<Vilao> BuscarViloes()
        {
            return new List<Vilao>()
            {
                new VilaoMarvel(){ Name = "Thanos"},
                new VilaoMarvel(){ Name = "Doende Verde"},
                new VilaoMarvel(){ Name = "Caveira Vermelha"},
                new VilaoMarvel(){ Name = "Magneto"},
                new VilaoMarvel(){ Name = "Loki"},
                new VilaoMarvel(){ Name = "Dr. Octopus"}
            };
        }
    }
}
