namespace CambioVeiculo.Domain.Base
{
    public abstract class CambioAutomatico
    {
        public string Name { get; set; }
        public TipoProduto Tipo { get; set; }

        public CambioAutomatico(TipoProduto tipo)
        {
            Tipo = tipo;
        }

        public abstract List<CambioAutomatico> ObterAutomaticos();
    }


}
