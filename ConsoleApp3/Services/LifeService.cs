using ConsoleApp3.Entities;
using System;

namespace ConsoleApp3.Services
{
    public class LifeService
    {
        public void LevelUpPokemonFullLife(Pokemons pokemons)
        {
            Random random = new Random();
            pokemons.MaxLife += random.Next(30, 50);
            pokemons.Life = pokemons.MaxLife;
        }
    }
}
