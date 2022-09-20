namespace MundoGeek.AbstractProducts
{
    public abstract class Vilao
    {
        public string Name { get; set; }
        public TipoProduto TipoProduto { get; set; }

        public Vilao(TipoProduto tipoProduto)
        {
            TipoProduto = tipoProduto;
        }

        public abstract List<Vilao> BuscarViloes();
    }
}
