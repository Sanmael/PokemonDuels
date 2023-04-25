using ConsoleApp3.Enumerations;
using System.Collections.Generic;

namespace ConsoleApp3.Entities
{
    public class Pokemons
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Habilitys { get; set; }
        public long Life { get; set; }
        public PokemonType Type { get; set; }

        public Pokemons(long id, string name, List<string> habilitys, long life, PokemonType type)
        {
            Id = id;
            Name = name;
            Habilitys = habilitys;
            Life = life;
            Type = type;
        }
    }
}
