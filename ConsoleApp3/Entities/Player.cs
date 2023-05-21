using System.Collections.Generic;


namespace ConsoleApp3.Entities
{
    public class Player
    {
        public long PlayerId { get; set; }
        public string Name { get; set; }
        public List<Pokemons> Pokemons { get; set; }
        public Pokemons UsedPokemon { get; set; }
        public bool Turn { get; set; }
        public long TotalLife { get; set; }
        public PokeDex PokeDex { get; set; }
        public Player(string name, List<Pokemons> pokemons, long playerId)
        {
            PlayerId = playerId;
            Name = name;
            Pokemons = pokemons;
            pokemons.ForEach(x => x.PlayerId = playerId);
            GetTotalLife();
            PokeDex = new PokeDex(playerId);
            pokemons.ForEach(x => PokeDex.DiscoveredPokemons.Add(new PokedexPokemon().CreatePokedexPokemon(playerId, x)));            
        }
        public void GetTotalLife()
        {
            Pokemons.ForEach(x => TotalLife += x.Life);
        }
    }
}
