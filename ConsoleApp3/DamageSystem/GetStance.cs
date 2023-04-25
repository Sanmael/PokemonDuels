using ConsoleApp3.Enumerations;
using ConsoleApp3.Entities;
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

        public void DealDamage(int hability, Player usedPlayer, Player enemyPlayer)
        {
            try
            {
                _pokemonSystem.DealDamage(hability, usedPlayer, enemyPlayer);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");

                enemyPlayer.UsedPokemon.Life -= 20;

                Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu {20} de dano, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");
            }
        }
    }
}
