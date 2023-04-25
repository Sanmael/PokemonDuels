using ConsoleApp3.Enumerations;
using ConsoleApp3.Entities;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DamageSystem
{
    public class WaterDamage : IPokemonSystem
    {

        public void DealDamage(int hability, Player usedPlayer, Player enemyPlayer)
        {
            WaterSkill water;

            if (Enum.IsDefined(typeof(WaterSkill), hability))            
                water = (WaterSkill)hability;
            
            else
                throw new Exception($"{usedPlayer.UsedPokemon.Name} usou ataque padrão !");

            long damage = ((long)GeralServices.GetEnumValue<WaterSkillDamage>(water.ToString()));

            enemyPlayer.UsedPokemon.Life -= damage;

            Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu o ataque {water.ToString()} causou {damage} de dano, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");
        }
    }
}
