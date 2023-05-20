using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    public class PokemonService
    {
        LevelService LevelService = new LevelService();
        public void ValidatePokemonHp(Player player, Pokemons enemyPokemons)
        {
            player.UsedPokemon = player.UsedPokemon.Life > 0 ? player.UsedPokemon : RemoveFaintedPokemon(player);

            while (player.UsedPokemon == null)
            {
                Console.Clear();

                Console.WriteLine($"{player.Name} - Seu Pokemon morreu escolha outro! \n");

                try
                {
                    Console.WriteLine("Qual pokemon irá usar?\n");

                    player.Pokemons.ForEach(x => Console.WriteLine($"{player.Pokemons.IndexOf(x)} - {x.Name} - {x.Type} \n"));

                    int newChoice = int.Parse(Console.ReadLine());

                    player.UsedPokemon = player.Pokemons.Where(x => player.Pokemons.IndexOf(x) == newChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                }

                ValidateExperience(enemyPokemons);
            }
        }
        public Pokemons RemoveFaintedPokemon(Player player)
        {
            player.Pokemons.Remove(player.UsedPokemon);

            return player.UsedPokemon = null;
        }
        public void TradePokemon(Player player)
        {
            player.UsedPokemon = null;

            while (player.UsedPokemon == null)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Qual pokemon irá usar\n");

                    player.Pokemons.ForEach(x => Console.WriteLine($"{player.Pokemons.IndexOf(x)} - {x.Name} - {x.Type} \n"));

                    int newChoice = int.Parse(Console.ReadLine());

                    player.UsedPokemon = player.Pokemons.Where(x => player.Pokemons.IndexOf(x) == newChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                }
            }
        }
        public void AddNewPokemonDetails(PokeDex pokeDex, Pokemons pokemons)
        {
            if (!pokeDex.DiscoveredPokemons.Where(x => x.PokemonName == pokemons.Name).Any())
                pokeDex.DiscoveredPokemons.Add(new PokedexPokemon().CreatePokedexPokemon(pokeDex.PlayerId, pokemons));
        }
        public PokedexPokemon GetPokemonDetails(string name, PokeDex pokeDex)
        {
            return pokeDex.DiscoveredPokemons.Where(x => x.PokemonName.Equals(name)).FirstOrDefault();
        }
        public void ValidateExperience(Pokemons enemyPokemons)
        {
            LevelService.ValidateLevelUp(enemyPokemons);
        }
    }

}

