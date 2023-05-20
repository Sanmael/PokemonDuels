using ConsoleApp3.AppDbContext;
using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    public class LifeService
    {
        public void LevelUpPokemonFullLife(Pokemons pokemons)
        {
            pokemons.Life = pokemons.MaxLife;
        }
    }
}
