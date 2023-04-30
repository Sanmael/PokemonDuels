using ConsoleApp3.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class PokedexPokemon
    {        
        public long PlayerId { get; set; }
        public string PokemonName { get; set; }
        public List<Habilidades> Habilitys { get; set; }        
        public PokemonType Type { get; set; }
        public string Description { get; set; }

        public PokedexPokemon CreatePokedexPokemon(long playerId,Pokemons pokemons)
        {
            PlayerId = playerId;
            PokemonName = pokemons.Name;
            Habilitys = pokemons.Habilitys;
            Type = pokemons.Type;
            Description = pokemons.Description;

            return this;
        }
    }
}
