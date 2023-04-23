using ConsoleApp3.Entities;
using ConsoleApp3.Interfaces;
using ConsoleApp3.DamageSystem;
using System;

namespace ConsoleApp3.Services
{
    public class BattleService
    {
        public static PlayerService _playerService;
        public static PokemonService _pokemonService;
        public BattleService(PlayerService playerService, PokemonService pokemonService)
        {
            _playerService = playerService;
            _pokemonService = pokemonService;
        }
        public void Duel(Player usedPlayer, Player enemyPlayer)
        {
            usedPlayer.Turn = false;

            Console.WriteLine($"{usedPlayer.Name} -- {usedPlayer.UsedPokemon.Name} -- {usedPlayer.UsedPokemon.Life} \n");

            Console.WriteLine("Deseja atacar ou trocar de Pokemon? \n");

            Console.WriteLine("1 - Atacar , 2 - Trocar \n");

            string attackOrTrade = Console.ReadLine();

            if (attackOrTrade == "2")
            {
                _pokemonService.TradePokemon(usedPlayer);

                enemyPlayer.Turn = true;

                return;
            }

            while (enemyPlayer.Turn == false)
            {
                try
                {
                    Console.WriteLine($"Qual Habilidade Deseja Usar? \n");

                    for (int i = 0; i < usedPlayer.UsedPokemon.Hability.Count; i++)
                    {
                        Console.WriteLine($"{i} - {usedPlayer.UsedPokemon.Hability[i]}");
                    }

                    IPokemonSystem IPokemonSystem = new GetStance(usedPlayer.UsedPokemon.Type);

                    enemyPlayer.UsedPokemon.Life -= IPokemonSystem.DealDamage(int.Parse(Console.ReadLine()));

                    enemyPlayer.Turn = true;
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                    continue;
                }
            }
        }
    }
}
