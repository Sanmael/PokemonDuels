using ConsoleApp3.AppDbContext;
using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    public class PlayerService
    {
        private readonly DataBase _dataBase;
        public long ids = 1;
        public PlayerService(DataBase dataBase)
        {
            _dataBase = dataBase;
        }
        public Player CreatePlayer()
        {
            Console.WriteLine("Nome do Novo Player");

            Player player = new Player(Console.ReadLine(), _dataBase.ReceivePokemons(), ids);

            while (player.UsedPokemon == null)
            {
                try
                {
                    Console.WriteLine($"Qual pokemon irá usar {player.Name}\n");

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

            ids++;

            return player;
        }
        public bool ValidatePlayerLife(Player player)
        {
            player.TotalLife = 0;

            player.GetTotalLife();

            return player.TotalLife > 0 ? true : false;
        }
        public void FirstPlayer(Player player1, Player player2)
        {
            List<Player> decideTheFirst = new List<Player>() { player1, player2 };

            Player first = decideTheFirst.OrderBy(x => Guid.NewGuid()).First();

            Console.WriteLine($"o jogador {first.Name} será o primeiro a jogar!\n");

            Thread.Sleep(2000);

            player1.Turn = first.Name.Equals(player1.Name) ? true : false;
        }
    }
}
