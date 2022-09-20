namespace MundoGeek.AbstractProducts
{
    public abstract class Heroi
    {
        public string Name { get; set; }
        public TipoProduto TipoProduto { get; set; }

        public Heroi(TipoProduto tipoProduto)
        {
            TipoProduto = tipoProduto;
        }

        public abstract List<Heroi> BuscarHerois();
    }
}
