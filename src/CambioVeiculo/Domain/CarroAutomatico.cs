using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.Domain
{
    public class CarroAutomatico : CambioAutomatico
    {
        public CarroAutomatico(): base(TipoProduto.Carro)
        {

        }
        public override List<CambioAutomatico> ObterAutomaticos()
        {
            return new List<CambioAutomatico>()
            {
                new CarroAutomatico(){ Name = "Polo Comfortline TSI"},
                new CarroAutomatico(){ Name = "Onix LTZ"},
                new CarroAutomatico(){ Name = "Tracker LT"},
            };
        }
    }
}
