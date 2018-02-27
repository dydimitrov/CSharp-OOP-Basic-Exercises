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

            var secondCommand = Console.ReadLine();

            while (secondCommand != "End")
            {
                foreach (var trainer in listOfTrainers)
                {
                    bool hasPokemon = false;
                    foreach (var poke in trainer.ListOfPokemons)
                    {
                        if (poke.Element.ToLower() == secondCommand.ToLower())
                        {
                            hasPokemon = true;
                            trainer.Badges++;
                        }
                    }
                    if (hasPokemon == false )
                    {
                        foreach (var pokemon in trainer.ListOfPokemons)
                        {
                            if ((pokemon.Health-10)>0)
                            {
                                pokemon.Health -= 10;
                            }
                            else
                            {
                                trainer.ListOfPokemons.Remove(pokemon);
                            }
                        }
                    }
                }
                secondCommand = Console.ReadLine();
            }
        }
    }
}
