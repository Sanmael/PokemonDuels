using ConsoleApp3.Entities;
using ConsoleApp3.Interfaces;
using ConsoleApp3.DamageSystem;
using System;
using System.Threading;

namespace ConsoleApp3.Services
{
    public class BattleService
    {        
        private readonly PokemonService _pokemonService;
        public BattleService(PokemonService pokemonService)
        {            
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

                    IPokemonSystem iPokemonSystem = new GetStance(usedPlayer.UsedPokemon.Type);

                    iPokemonSystem.DealDamage(int.Parse(Console.ReadLine()),usedPlayer,enemyPlayer);

                    enemyPlayer.Turn = true;                                  

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
