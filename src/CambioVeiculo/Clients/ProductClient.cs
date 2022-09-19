using CambioVeiculo.AbstractFactories;
using CambioVeiculo.AbstractFactory;
using CambioVeiculo.Domain.Base;

namespace CambioVeiculo.Clients
{
    public class ProductClient
    {
        private readonly CambioAutomatico _cambioAutomatico;
        private readonly CambioManual _cambioManual;
        public ProductClient(ProductFactory productFactory)
        {
            _cambioAutomatico = productFactory.CriarAutomatico();
            _cambioManual = productFactory.CriarManual();
        }

        public List<CambioAutomatico> ObterAutomaticos()
        {
           return _cambioAutomatico.ObterAutomaticos(); 
        }

        public List<CambioManual> ObterManuais()
        {
            return _cambioManual.ObterManuais();  
        }

        public static ProductClient CriarProductClient(TipoProduto tipo)
        {
            switch (tipo)
            {
                case TipoProduto.Carro:
                    return new ProductClient(new ProductCarroFactory());
                    break;
                case TipoProduto.Moto:
                    return new ProductClient(new ProductMotoFactory());
                    break;
                default:
                    throw new Exception("Not Found");
            }
        }

    }
}
