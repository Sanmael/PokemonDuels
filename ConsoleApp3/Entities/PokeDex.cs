using System.Collections.Generic;


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
