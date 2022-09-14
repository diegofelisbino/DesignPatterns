using MundoAnimal.AbstractProduct;

namespace MundoAnimal.Product
{
    internal class Lobo : Carnivoro
    {
        public override string Eat(Herbivoro herbivoro)
        {
            return $"{this.GetType().Name} come {herbivoro.GetType().Name}";
        }
    }

}
