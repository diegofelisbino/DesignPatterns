using MundoAnimal.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal.Product
{
    class Leao : Carnivoro
    {
        public override string Eat(Herbivoro herbivoro)
        {
            return $"{this.GetType().Name} come {herbivoro.GetType().Name}";
        }
    }

}
