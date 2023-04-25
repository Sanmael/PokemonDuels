using ConsoleApp3.Enumerations;
using ConsoleApp3.Entities;
using ConsoleApp3.DamageSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp3.Services;

namespace ConsoleApp3.AppDbContext
{
    public class DataBase
    {
        public List<Pokemons> ReceivePokemons()
        {
            List<string> fireSkill = GeralServices.ReceiveSkill<FireSkill>().OrderBy(x=> Guid.NewGuid()).Take(3).ToList();
            List<string> waterSkill = GeralServices.ReceiveSkill<WaterSkill>().OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            List<string> earthSkill = GeralServices.ReceiveSkill<EarthSkill>().OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            List<string> plantSkill = GeralServices.ReceiveSkill<PlantSkill>().OrderBy(x => Guid.NewGuid()).Take(3).ToList();

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
