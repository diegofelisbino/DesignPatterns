// See https://aka.ms/new-console-template for more information

using MundoAnimal.AbstractFactory;
using MundoAnimal.Client;
using MundoAnimal.ConcreteFactory;

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Mundo Animal");
Console.WriteLine("------------------------------------------------------");

ContinenteFactory africa = new AfricaFactory();
MundoAnimalClient mundoAnimalAfricano = new MundoAnimalClient(africa);
Console.WriteLine("Cadeia Alimentar Africana");
Console.WriteLine(mundoAnimalAfricano.ExecutarCadeiaAlimentar());

Console.WriteLine("------------------------------------------------------");

ContinenteFactory america = new AmericaFactory();
MundoAnimalClient mundoAnimalAmericano = new MundoAnimalClient(america);
Console.WriteLine("Cadeia Alimentar Americana");
Console.WriteLine(mundoAnimalAmericano.ExecutarCadeiaAlimentar());

Console.ReadKey();
