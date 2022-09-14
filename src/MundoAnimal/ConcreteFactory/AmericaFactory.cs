using MundoAnimal.AbstractFactory;
using MundoAnimal.AbstractProduct;
using MundoAnimal.Product;

namespace MundoAnimal.ConcreteFactory
{
    //ConcreteFactory
    class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivo()
        {
            return new Lobo(); 
        }

        public override Herbivoro CriarHerbivoro()
        {
            return new Bufalo();
        }
    }
}
