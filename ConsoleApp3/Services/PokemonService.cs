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
        public void ValidatePokemonHp(Player Player)
        {
            Player.UsedPokemon = Player.UsedPokemon.Life > 0 ? Player.UsedPokemon : RemoveFaintedPokemon(Player);

            while (Player.UsedPokemon == null)
            {
                Console.WriteLine("Seu Pokemon morreu escolha outro! \n");

                try
                {
                    Player.Pokemons.ForEach(x => Console.WriteLine($"Qual pokemon irá usar {x.Id} - {x.Name} ? \n"));

                    int newChoice = int.Parse(Console.ReadLine());

                    Player.UsedPokemon = Player.Pokemons.Where(x => x.Id == newChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                    continue;
                }
            }
        }
        public Pokemons RemoveFaintedPokemon(Player Player)
        {
            Player.Pokemons.Remove(Player.UsedPokemon);

            return Player.UsedPokemon = null;
        }
        public void TradePokemon(Player Player)
        {
            Player.UsedPokemon = null;

            while (Player.UsedPokemon == null)
            {
                try
                {
                    Player.Pokemons.ForEach(x => Console.WriteLine($"Qual pokemon irá usar {x.Id} - {x.Name} ? \n"));

                    int newChoice = int.Parse(Console.ReadLine());

                    Player.UsedPokemon = Player.Pokemons.Where(x => x.Id == newChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                    continue;
                }
            }
        }
    }

}

