using ConsoleApp3.Entities;
using System;

namespace ConsoleApp3.Services
{
    public class BattleService
    {        
        PokemonService _pokemonService;
        ChoiceService _choiceService;
        public BattleService(PokemonService pokemonService)
        {            
            _pokemonService = pokemonService;
            _choiceService = new ChoiceService(_pokemonService);
        }
        public void Duel(Player usedPlayer, Player enemyPlayer)
        {
            Console.Clear();

            _pokemonService.AddNewPokemonDetails(usedPlayer.PokeDex, enemyPlayer.UsedPokemon);

            usedPlayer.Turn = false;

            _choiceService.PlayerChoice(usedPlayer,enemyPlayer);
           
            while (enemyPlayer.Turn == false)
            {
                _choiceService.Battle(usedPlayer, enemyPlayer);
            }
        }
    }
}
