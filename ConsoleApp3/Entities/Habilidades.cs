using ConsoleApp3.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class Habilidades
    {
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public long Damage { get; set; }
    }
}
