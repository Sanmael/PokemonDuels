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
            Player Player = new Player();

            Console.WriteLine("Nome do Player \n");

            Player.Name = Console.ReadLine();

            Player.Pokemons = _dataBase.ReceivePokemons();

            Player.Pokemons.ForEach(x => Player.TotalLife += x.Life);

            while (Player.UsedPokemon == null)
            {
                try
                {
                    Player.Pokemons.ForEach(x => Console.WriteLine($"Qual pokemon irá usar {x.Id} - {x.Name} ? \n"));

                    int firstChoice = int.Parse(Console.ReadLine());

                    Player.UsedPokemon = Player.Pokemons.Where(x => x.Id == firstChoice).FirstOrDefault();
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");

                    continue;
                }
            }
            return Player;
        }
        public bool ValidatePlayerLife(Player Player)
        {
            Player.TotalLife = 0;

            Player.Pokemons.ForEach(x => Player.TotalLife += x.Life);

            return Player.TotalLife > 0 ? true : false;
        }
    }
}
