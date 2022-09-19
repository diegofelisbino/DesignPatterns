using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.AbstractFactory
{
    public abstract class ProductFactory
    {
        public abstract CambioManual CriarManual();

        public abstract CambioAutomatico CriarAutomatico();

    }
}
