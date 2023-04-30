using ConsoleApp3.Entities;
using ConsoleApp3.DamageSystem;
using System;
using System.Linq;
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

            _pokemonService.AddNewPokemonDetails(usedPlayer.PokeDex, enemyPlayer.UsedPokemon);

            usedPlayer.Turn = false;

            Console.WriteLine($"Turno de {usedPlayer.Name} - Pokemon : {usedPlayer.UsedPokemon.Name} -" +
                $" Vida Restante : {usedPlayer.UsedPokemon.Life} \n\nDeseja atacar ou trocar de Pokemon? \n\n1 -" +
                $" Atacar , 2 - Trocar, 3 - Olhar Pokedex e ver O Pokemon Adversario\n");

            string attackOrTrade = Console.ReadLine();

            if (attackOrTrade == "2")
            {
                _pokemonService.TradePokemon(usedPlayer);

                enemyPlayer.Turn = true;
            }

            if(attackOrTrade == "3")
            {
                PokedexPokemon achou = _pokemonService.GetPokemonDetails(enemyPlayer.UsedPokemon.Name, usedPlayer.PokeDex);
                Console.WriteLine($"{achou.PokemonName} é um pokemon do tipo {achou.Type}\n{achou.Description}\nHabilidades: {achou.Habilitys.Select(x =>x.Name)}");
            }

            while (enemyPlayer.Turn == false)
            {
                try
                {
                    Console.WriteLine($"\nQual Habilidade Deseja Usar? \n");

                    for (int i = 0; i < usedPlayer.UsedPokemon.Habilitys.Count; i++)
                    {
                        Console.WriteLine($"{i} - {usedPlayer.UsedPokemon.Habilitys[i].Name}\n");
                    }

                    Habilidades habilidades = usedPlayer.UsedPokemon.Habilitys[(int.Parse(Console.ReadLine()))];

                    new Damage().DealDamage(habilidades, usedPlayer,enemyPlayer);

                    enemyPlayer.Turn = true;                                  

                    Thread.Sleep(3000);
                }
                catch
                {
                    Console.WriteLine("\nOpção invalida, digite novamente \n");
                }
            }
        }
    }
}
