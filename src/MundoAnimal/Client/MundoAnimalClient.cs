using MundoAnimal.AbstractFactory;
using MundoAnimal.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal.Client
{
    public class MundoAnimalClient
    {
        private Herbivoro _herbivoro;
        private Carnivoro _carnivoro;

        public MundoAnimalClient(ContinenteFactory factory)
        {
            _herbivoro = factory.CriarHerbivoro();
            _carnivoro = factory.CriarCarnivo();
        }

        public string ExecutarCadeiaAlimentar()
        {
            return _carnivoro.Eat(_herbivoro);
        }

        
    }
}
