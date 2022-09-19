using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.Domain
{
    public class MotoManual : CambioManual
    {
        public MotoManual() : base(TipoProduto.Moto)
        {

        }
        public override List<CambioManual> ObterManuais()
        {
            return new List<CambioManual>()
            {
                new MotoManual(){ Name = "Titan"},
                new MotoManual(){ Name = "Biz"}
            };
        }
    }
}
