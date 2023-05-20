using ConsoleApp3.Enumerations;
using System.Collections.Generic;

namespace ConsoleApp3.Entities
{
    public class Pokemons
    {
        public long Id { get; set; }
        public long? PlayerId { get; set; }
        public string Name { get; set; }
        public List<Habilidades> Habilitys { get; set; }
        public long Life { get; set; }
        public long MaxLife { get; set; }
        public PokemonType Type { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public string Description { get; set; }
        public Pokemons(long id, string name, List<Habilidades> habilitys, long life, PokemonType type,string description)
        {
            Id = id;
            Name = name;
            Habilitys = habilitys;
            Life = life;
            Type = type;
            Description = description;
            Level = 1;
            MaxLife = Life;
        }
    }
}
