using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.Domain
{
    public class MotoAutomatico : CambioAutomatico
    {
        public MotoAutomatico() : base(TipoProduto.Moto)
        {

        }
        public override List<CambioAutomatico> ObterAutomaticos()
        {
            return new List<CambioAutomatico>()
            {
                new MotoAutomatico(){ Name = "Pcx"},
                new MotoAutomatico(){ Name = "Nmax"}
            };
        }
    }
}
