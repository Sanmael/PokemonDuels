using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class PokeDex
    {
        public long PokeDexId { get; set; }
        public long PlayerId { get; set; }
        public List<PokedexPokemon> DiscoveredPokemons { get; set; }

        public PokeDex(long playerId)
        {            
            PlayerId = playerId;
            DiscoveredPokemons = new List<PokedexPokemon>();
        }        

    }
}
