using ConsoleApp3.AppDbContext;
using ConsoleApp3.Entities;
using ConsoleApp3.Services;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();

            var _playerService = new PlayerService(dataBase);
            var _pokemonService = new PokemonService();
            var _battleService = new BattleService(_pokemonService);

            //instanciando Playeres
            Player player1 = _playerService.CreatePlayer();
            Player player2 = _playerService.CreatePlayer();

            _playerService.FirstPlayer(player1, player2);

            //Inicio do Duelo
            while (_playerService.ValidatePlayerLife(player1) && _playerService.ValidatePlayerLife(player2))
            {
                if (player1.Turn)
                {
                    _pokemonService.ValidatePokemonHp(player1, player2.UsedPokemon);                        
                    _battleService.Duel(player1, player2);
                    continue;
                }
                _pokemonService.ValidatePokemonHp(player2, player1.UsedPokemon);                    
                _battleService.Duel(player2, player1);
            }

            string winnerPlayer = _playerService.ValidatePlayerLife(player1) ? player1.Name : player2.Name;

            Console.WriteLine($"Player : {winnerPlayer} Ganhou!");         
        }
    }
}

