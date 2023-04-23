using ConsoleApp3.Entities;
using ConsoleApp3.Interfaces;
using ConsoleApp3.DamageSystem;
using System;
using System.Threading;

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
            Console.Clear();

            usedPlayer.Turn = false;

            Console.WriteLine($"Turno de {usedPlayer.Name} - Pokemon : {usedPlayer.UsedPokemon.Name} - Vida Restante : {usedPlayer.UsedPokemon.Life} \n\nDeseja atacar ou trocar de Pokemon? \n\n1 - Atacar , 2 - Trocar \n");

            string attackOrTrade = Console.ReadLine();

            if (attackOrTrade == "2")
            {
                _pokemonService.TradePokemon(usedPlayer);

                enemyPlayer.Turn = true;
            }

            while (enemyPlayer.Turn == false)
            {
                try
                {
                    Console.WriteLine($"\nQual Habilidade Deseja Usar? \n");

                    for (int i = 0; i < usedPlayer.UsedPokemon.Habilitys.Count; i++)
                    {
                        Console.WriteLine($"{i} - {usedPlayer.UsedPokemon.Habilitys[i]}\n");
                    }

                    IPokemonSystem IPokemonSystem = new GetStance(usedPlayer.UsedPokemon.Type);

                    long damage = IPokemonSystem.DealDamage(int.Parse(Console.ReadLine()));

                    enemyPlayer.Turn = true;

                    enemyPlayer.UsedPokemon.Life -= damage;                    

                    Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu {damage} de dano, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");

                    Thread.Sleep(3000);
                }
                catch
                {
                    Console.WriteLine("Opção invalida, digite novamente \n");
                }
            }
        }
    }
}
