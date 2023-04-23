using ConsoleApp3.AppDbContext;
using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
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
            var _battleService = new BattleService(_playerService, _pokemonService);

            //instanciando Playeres
            Player Player1 = _playerService.CreatePlayer();

            Player Player2 = _playerService.CreatePlayer();

            //Inicio do Duelo
            while (_playerService.ValidatePlayerLife(Player1) && _playerService.ValidatePlayerLife(Player2))
            {
                if (Player1.Turn)
                {
                    _pokemonService.ValidatePokemonHp(Player1);
                    _battleService.Duel(Player1, Player2);
                    continue;
                }

                _pokemonService.ValidatePokemonHp(Player2);
                _battleService.Duel(Player2, Player1);
            }

            string winnerPlayer = _playerService.ValidatePlayerLife(Player1) ? Player1.Name : Player2.Name;

            Console.WriteLine($"Player : {winnerPlayer} Ganhou!");
        }
    }
}

