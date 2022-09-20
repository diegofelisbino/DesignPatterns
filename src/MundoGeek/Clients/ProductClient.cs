using MundoGeek.AbstractFactories;
using MundoGeek.AbstractProducts;
using MundoGeek.ConcreteFactories;

namespace MundoGeek.Clients
{
    public class ProductClient
    {
        private readonly Heroi _heroi;
        private readonly Vilao _vilao;
        public ProductClient(ProductFactory productFactory)
        {
            _heroi = productFactory.CriarHeroi();
            _vilao = productFactory.CriarVilao();
        }

        public List<Heroi> BuscarHerois()
        {
            return _heroi.BuscarHerois();   
        }

        public List<Vilao> BuscarViloes()
        {
            return _vilao.BuscarViloes();   
        }

        public static ProductClient CriarProductClient(TipoProduto tipo)
        {
            switch (tipo)
            {
                case TipoProduto.Marvel:
                    return new ProductClient(new MarvelFactory());                    
                case TipoProduto.Dc:
                    return new ProductClient(new DcFactory());  
                default:
                    throw new Exception("Not Found");
            }
        }


    }
}
