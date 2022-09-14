using MundoAnimal.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal.AbstractFactory
{
    //AbstractFactory
    public abstract class ContinenteFactory
    {
        public abstract Herbivoro CriarHerbivoro();
        public abstract Carnivoro CriarCarnivo();
    }
}
