namespace CambioVeiculo.Domain.Base
{
    public abstract class CambioManual
    {
        public string Name { get; set; }
        public TipoProduto Tipo { get; set; }

        public CambioManual(TipoProduto tipo)
        {
            Tipo = tipo;
        }

        public abstract List<CambioManual> ObterManuais();
    }


}
