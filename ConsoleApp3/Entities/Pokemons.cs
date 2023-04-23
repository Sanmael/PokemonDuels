using ConsoleApp3.AllEnum;
using System.Collections.Generic;

namespace ConsoleApp3.Entities
{
    public class Pokemons
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Hability { get; set; }
        public long Life { get; set; }
        public PokemonType Type { get; set; }

        public Pokemons(long id, string name, List<string> hability, long life, PokemonType type)
        {
            Id = id;
            Name = name;
            Hability = hability;
            Life = life;
            Type = type;
        }
    }
}
