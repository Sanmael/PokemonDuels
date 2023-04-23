using ConsoleApp3.AppDbContext;
using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    public class PlayerService
    {
        private readonly DataBase _dataBase;
        public PlayerService(DataBase dataBase)
        {
            _dataBase = dataBase;
        }
        public Player CreatePlayer()
        {
            Player player = new Player();

            Console.WriteLine("Nome do Novo Player");

            player.Name = Console.ReadLine();

            player.Pokemons = _dataBase.ReceivePokemons();

            player.Pokemons.ForEach(x => player.TotalLife += x.Life);

            while (player.UsedPokemon == null)
            {
                try
                {
                    Console.WriteLine("Qual pokemon irá usar?\n");

                    player.Pokemons.ForEach(x => Console.WriteLine($"{player.Pokemons.IndexOf(x)} - {x.Name} - {x.Type} \n"));

                    int firstChoice = int.Parse(Console.ReadLine());

                    player.UsedPokemon = player.Pokemons.Where(x => player.Pokemons.IndexOf(x) == firstChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                }
            }
            Console.Clear();

            return player;
        }
        public bool ValidatePlayerLife(Player player)
        {
            player.TotalLife = 0;

            player.Pokemons.ForEach(x => player.TotalLife += x.Life);

            return player.TotalLife > 0 ? true : false;
        }
    }
}
