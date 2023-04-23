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
            List<string> fireSkill = new GetStance(PokemonType.Fire).ReceiveSkill();
            List<string> waterSkill = new GetStance(PokemonType.Water).ReceiveSkill();
            List<string> earthSkill = new GetStance(PokemonType.Rock).ReceiveSkill();
            List<string> plantSkill = new GetStance(PokemonType.Plant).ReceiveSkill();

            List<Pokemons> pokemons = new List<Pokemons>()
            {
            new Pokemons(1, "Charmander", fireSkill, 100, PokemonType.Fire),
            new Pokemons(2, "FogoNaChota", fireSkill, 100, PokemonType.Fire),
            new Pokemons(3, "Bulbasaur", plantSkill, 130, PokemonType.Plant),
            new Pokemons(4, "Squirtle", waterSkill, 110, PokemonType.Water),
            new Pokemons(6, "Geodude", earthSkill, 140, PokemonType.Rock),
            new Pokemons(7, "Vaporeon", waterSkill, 150, PokemonType.Water),
            new Pokemons(8, "Charmeleon", fireSkill, 130, PokemonType.Fire),
            new Pokemons(9, "Ivysaur", plantSkill, 120, PokemonType.Plant),
            new Pokemons(10,"Wartortle", waterSkill, 110, PokemonType.Water)
            };

            return pokemons.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
        }
    }
}
