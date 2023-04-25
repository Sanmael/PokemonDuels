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
        public Player(string name, List<Pokemons> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
            GetTotalLife();
        }
        public void GetTotalLife()
        {
            Pokemons.ForEach(x => TotalLife += x.Life);
        }
    }
}
