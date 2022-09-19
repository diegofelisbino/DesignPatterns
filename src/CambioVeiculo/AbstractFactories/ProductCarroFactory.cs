using CambioVeiculo.AbstractFactory;
using CambioVeiculo.Domain;
using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.AbstractFactories
{
    public class ProductCarroFactory : ProductFactory
    {
        public override CambioAutomatico CriarAutomatico()
        {
            return new CarroAutomatico();
        }

        public override CambioManual CriarManual()
        {
            return new CarroManual();
        }
    }
}
