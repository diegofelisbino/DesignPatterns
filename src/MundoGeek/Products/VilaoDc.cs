using MundoGeek.AbstractProducts;

namespace MundoGeek.Products
{
    public class VilaoDc : Vilao
    {

        public VilaoDc() : base(TipoProduto.Dc)
        {

        }
        public override List<Vilao> BuscarViloes()
        {
            return new List<Vilao>()
            {
                new VilaoMarvel{ Name = "Lex Luthor"},
                new VilaoMarvel{ Name = "Coringa"},
                new VilaoMarvel{ Name = "Apocalypse"},
                new VilaoMarvel{ Name = "Pinguim"},
                new VilaoMarvel{ Name = "Charada"}
            };
        }
    }
}
