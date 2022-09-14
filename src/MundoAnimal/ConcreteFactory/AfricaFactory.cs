using MundoAnimal.AbstractFactory;
using MundoAnimal.AbstractProduct;
using MundoAnimal.Product;

namespace MundoAnimal.ConcreteFactory
{
    //ConcreteFactory
    public class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivo()
        {
            return new Leao();
        }

        public override Herbivoro CriarHerbivoro()
        {
            return new Gnu();
        }
    }
}
