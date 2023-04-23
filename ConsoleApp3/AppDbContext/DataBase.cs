using ConsoleApp3.AllEnum;
using ConsoleApp3.Entities;
using ConsoleApp3.DamageSystem;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp3.AppDbContext
{
    public class DataBase
    {
        public List<Pokemons> ReceivePokemons()
        {
            List<string> FireSkill = new GetStance(PokemonType.Fire).ReceiveSkill();
            List<string> WaterSkill = new GetStance(PokemonType.Water).ReceiveSkill();
            List<string> EarthSkill = new GetStance(PokemonType.Rock).ReceiveSkill();
            List<string> PlantSkill = new GetStance(PokemonType.Plant).ReceiveSkill();

            List<Pokemons> pokemons = new List<Pokemons>()
            {
            new Pokemons(1, "Charmander", FireSkill, 100, PokemonType.Fire),
            new Pokemons(2, "FogoNaChota", FireSkill, 100, PokemonType.Fire),
            new Pokemons(3, "Bulbasaur", PlantSkill, 130, PokemonType.Plant),
            new Pokemons(4, "Squirtle", WaterSkill, 110, PokemonType.Water),
            new Pokemons(6, "Geodude", EarthSkill, 140, PokemonType.Rock),
            new Pokemons(7, "Vaporeon", WaterSkill, 150, PokemonType.Water),
            new Pokemons(8, "Charmeleon", FireSkill, 130, PokemonType.Fire),
            new Pokemons(9, "Ivysaur", PlantSkill, 120, PokemonType.Plant),
            new Pokemons(10,"Wartortle", WaterSkill, 110, PokemonType.Water)
            };

            return pokemons.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
        }
    }
}
