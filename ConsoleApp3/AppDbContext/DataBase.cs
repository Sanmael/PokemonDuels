using ConsoleApp3.Enumerations;
using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.AppDbContext
{
    public class DataBase
    {
        public List<Pokemons> ReceivePokemons()
        {
            return DataBasePokemons().OrderBy(x => Guid.NewGuid()).Take(3).ToList();
        }
        public List<Pokemons> DataBasePokemons()
        {
            List<Habilidades> habilidades = new List<Habilidades>()
            {
                new Habilidades() { Name = "Lança-Chamas", Type = PokemonType.Fire, Damage = 50 },
                new Habilidades() { Name = "Bola de Fogo", Type = PokemonType.Fire, Damage = 70 },
                new Habilidades() { Name = "Explosão de Fogo", Type = PokemonType.Fire, Damage = 60 },
                new Habilidades() { Name = "Chama Furacão", Type = PokemonType.Fire, Damage = 55 },
                new Habilidades() { Name = "Dança das Chamas", Type = PokemonType.Fire, Damage = 60 },
                new Habilidades() { Name = "Chama da Vingança", Type = PokemonType.Fire, Damage = 45 },
                new Habilidades() { Name = "Hidro Bomba", Type = PokemonType.Water, Damage = 60 },
                new Habilidades() { Name = "Surf", Type = PokemonType.Water, Damage = 45 },
                new Habilidades() { Name = "Jato de Água", Type = PokemonType.Water, Damage = 70 },
                new Habilidades() { Name = "Cascata", Type = PokemonType.Water, Damage = 50 },
                new Habilidades() { Name = "Aqua Tail", Type = PokemonType.Water, Damage = 65 },
                new Habilidades() { Name = "Voz dos Mares", Type = PokemonType.Water, Damage = 60 },
                new Habilidades() { Name = "Lançamento de Rocha", Type = PokemonType.Rock, Damage = 70 },
                new Habilidades() { Name = "Terremoto", Type = PokemonType.Rock, Damage = 55 },
                new Habilidades() { Name = "Rochas Afiadas", Type = PokemonType.Rock, Damage = 45 },
                new Habilidades() { Name = "Esmagamento de Rocha", Type = PokemonType.Rock, Damage = 50 },
                new Habilidades() { Name = "Cabeçada de Pedra", Type = PokemonType.Rock, Damage = 65 },
                new Habilidades() { Name = "Ciclone de Pedras", Type = PokemonType.Rock, Damage = 60 },
                new Habilidades() { Name = "Folha Navalha", Type = PokemonType.Plant, Damage = 70 },
                new Habilidades() { Name = "Raio Solar", Type = PokemonType.Plant, Damage = 55 },
                new Habilidades() { Name = "Bomba de Semente", Type = PokemonType.Plant, Damage = 45 },
                new Habilidades() { Name = "Folha Cortante", Type = PokemonType.Plant, Damage = 50 },
                new Habilidades() { Name = "Dança das Folhas", Type = PokemonType.Plant, Damage = 65 }
            };

            List<Pokemons> pokemons = new List<Pokemons>()
            {
            new Pokemons(1, "Charmander",habilidades.Where(x => x.Type == PokemonType.Fire).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 200, PokemonType.Fire,"Tem preferência por coisas quentes. Quando chove, diz-se que o vapor jorra da ponta da cauda."),
            new Pokemons(2, "FogoNaChota", habilidades.Where(x => x.Type == PokemonType.Fire).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 200, PokemonType.Fire,"FogoNaChota é um Pokémon de temperamento agressivo que ataca inimigos e amigos sem discriminação. FogoNaChota é a forma evoluída de um Charmeleon que perdeu seu treinador e ficou perambulando pelo mundo."),
            new Pokemons(3, "Bulbasaur", habilidades.Where(x => x.Type == PokemonType.Plant).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 260, PokemonType.Plant,"Há uma semente em suas costas desde o dia em que nasceu. Essa semente cresce lentamente."),
            new Pokemons(4, "Squirtle", habilidades.Where(x => x.Type == PokemonType.Water).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 220, PokemonType.Water,"Ao nascer, tem uma cauda curta que muda lentamente para uma maior à medida que ele envelhece."),
            new Pokemons(6, "Geodude", habilidades.Where(x => x.Type == PokemonType.Rock).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 150, PokemonType.Rock,"Geodude é encontrado em campos de montanha. Se você bater na montanha em que este Pokémon vive, ele balança e balança. Batendo na montanha pode causar uma avalanche, o que pode ser perigoso."),
            new Pokemons(7, "Vaporeon", habilidades.Where(x => x.Type == PokemonType.Water).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 300, PokemonType.Water,"Vaporeon é um Pokémon que vive próximo a rios, lagos e outras fontes de água. Seu corpo está adaptado para viver em ambientes aquáticos e é capaz de se transformar em água para evitar ataques."),
            new Pokemons(8, "Charmeleon", habilidades.Where(x => x.Type == PokemonType.Fire).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 260, PokemonType.Fire,"Tem uma personalidade feroz. Se você encontra-se com um Charmeleon em uma batalha, será necessário estar preparado para enfrentar um oponente muito forte."),
            new Pokemons(9, "Ivysaur", habilidades.Where(x => x.Type == PokemonType.Plant).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 240, PokemonType.Plant,"Quando a semente cresce, torna-se mais pesada e começa a se mover lentamente. A semente eventualmente se abre e um Pokémon começa a crescer a partir dela."),
            new Pokemons(10,"Wartortle", habilidades.Where(x => x.Type == PokemonType.Water).OrderBy(x => Guid.NewGuid()).Take(3).ToList(), 220, PokemonType.Water,"Wartortle tem uma cauda longa e espinhosa, que ele usa para nadar com grande habilidade. Este Pokémon pode nadar muito rapidamente e é capaz de nadar longas distâncias.")
            };
            return pokemons;
        }
        public Pokemons GetPokemonsById(long id)
        {
            return DataBasePokemons().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
