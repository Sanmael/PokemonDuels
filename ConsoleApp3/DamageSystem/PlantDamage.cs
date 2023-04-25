using ConsoleApp3.Enumerations;
using ConsoleApp3.Entities;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.DamageSystem
{
    public class PlantDamage : IPokemonSystem
    {
        public void DealDamage(int hability, Player usedPlayer, Player enemyPlayer)
        {
            PlantSkill plant;

            if (Enum.IsDefined(typeof(PlantSkill), hability))
            {
                plant = (PlantSkill)hability;
            }

            else
                throw new Exception($"{usedPlayer.UsedPokemon.Name} usou ataque padrão !");

            long damage = ((long)GeralServices.GetEnumValue<PlantSkillDamage>(plant.ToString()));

            enemyPlayer.UsedPokemon.Life -= damage;

            Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu o ataque {plant.ToString()} causou {damage} de dano, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");
        }
    }
}
