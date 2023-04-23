using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DamageSystem
{
    public class GetStance : IPokemonSystem
    {
        private IPokemonSystem _pokemonSystem;
        public GetStance(PokemonType pokemonType)
        {
            switch (pokemonType)
            {
                case PokemonType.Fire:
                    _pokemonSystem = new FireDamage();
                    break;
                case PokemonType.Plant:
                    _pokemonSystem = new PlantDamage();
                    break;
                case PokemonType.Rock:
                    _pokemonSystem = new EarthDamage();
                    break;
                case PokemonType.Water:
                    _pokemonSystem = new WaterDamage();
                    break;
            }
        }

        public long DealDamage(int hability)
        {
            return _pokemonSystem.DealDamage(hability);
        }

    }
}
