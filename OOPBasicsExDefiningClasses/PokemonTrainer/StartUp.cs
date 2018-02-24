using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var command = Console.ReadLine();
            var listOfTrainers = new HashSet<Trainer>();

            while (command != "Tournament")
            {
                var line = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Pokemon curretPokemon = new Pokemon();
                curretPokemon.Name = line[1];
                curretPokemon.Element = line[2];
                curretPokemon.Health = int.Parse(line[3]);

                Trainer currentTrainer = new Trainer();
                currentTrainer.Name = line[0];
                currentTrainer.ListOfPokemons.Add(curretPokemon);

                listOfTrainers.Add(currentTrainer);
                command = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
