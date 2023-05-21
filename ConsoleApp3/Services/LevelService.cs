using ConsoleApp3.Entities;
using System;

namespace ConsoleApp3.Services
{
    public class LevelService
    {
        LifeService LifeService = new LifeService();
        public void ValidateLevelUp(Pokemons pokemons)
        {
            Random random = new Random();

            //por enquanto 
            pokemons.Experience += random.Next(50, 100);

            switch (pokemons.Level)
            {
                case <= 10:
                    ValidateExperienceAtLevel10(pokemons);
                    break;
                case <= 20:

                    break;

                case <= 30:
                    break;

                default:
                    new NotImplementedException();
                    break;
            }
        }
        protected void ValidateExperienceAtLevel10(Pokemons usedPokemon)
        {
            int levelQuandoChegou = usedPokemon.Level;

            usedPokemon.Level =
            usedPokemon.Experience <= 100 ? 2 :
            usedPokemon.Experience <= 200 ? 3 :
            usedPokemon.Experience <= 300 ? 4 :
            usedPokemon.Experience <= 400 ? 5 :
            usedPokemon.Experience <= 500 ? 6 :
            usedPokemon.Experience <= 600 ? 7 :
            usedPokemon.Experience <= 700 ? 8 :
            usedPokemon.Experience <= 800 ? 9 : 10;

            if (usedPokemon.Level != levelQuandoChegou)
                LifeService.LevelUpPokemonFullLife(usedPokemon);
        }
    }
}
