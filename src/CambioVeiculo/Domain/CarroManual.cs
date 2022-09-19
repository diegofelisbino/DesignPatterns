using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.Domain
{
    public class CarroManual : CambioManual
    {
        public CarroManual() : base(TipoProduto.Carro)
        {

        }

        public override List<CambioManual> ObterManuais()
        {
            return new List<CambioManual>()
                {
                    new CarroManual(){ Name = "Fox MSI"},
                    new CarroManual(){ Name = "Celta LT"},
                    new CarroManual(){ Name = "Gol MSI"}
                };
        }
    }
}
