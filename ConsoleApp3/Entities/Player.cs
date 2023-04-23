using System.Collections.Generic;

namespace ConsoleApp3.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public List<Pokemons> Pokemons { get; set; }
        public Pokemons UsedPokemon { get; set; }
        public bool Turn { get; set; }
        public long TotalLife { get; set; }
    }
}
