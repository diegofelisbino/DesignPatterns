using CambioVeiculo.AbstractFactory;
using CambioVeiculo.Domain;
using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.AbstractFactories
{
    public class ProductMotoFactory : ProductFactory
    {
        public override CambioAutomatico CriarAutomatico()
        {
            return new MotoAutomatico();    
        }

        public override CambioManual CriarManual()
        {
           return new MotoManual();
        }
    }
}
