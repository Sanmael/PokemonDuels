using ConsoleApp3.AppDbContext;
using ConsoleApp3.Enumerations;
using ConsoleApp3.Services;
using ConsoleApp3.DamageSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ConsoleApp3.Entities;

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
                    _pokemonService.ValidatePokemonHp(player1);
                    _battleService.Duel(player1, player2);
                    continue;
                }

                _pokemonService.ValidatePokemonHp(player2);
                _battleService.Duel(player2, player1);
            }

            string winnerPlayer = _playerService.ValidatePlayerLife(player1) ? player1.Name : player2.Name;

            Console.WriteLine($"Player : {winnerPlayer} Ganhou!");
        }
    }
}

