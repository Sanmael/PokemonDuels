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
    public class EarthDamage : IPokemonSystem
    {
        public void DealDamage(int hability, Player usedPlayer, Player enemyPlayer)
        {
            EarthSkill earth;

            if (Enum.IsDefined(typeof(EarthSkill), hability))
            {
                earth = (EarthSkill)hability;
            }

            else
                throw new Exception($"{usedPlayer.UsedPokemon.Name} usou ataque padrão !");

            long damage = ((long)GeralServices.GetEnumValue<EarthSkillDamage>(earth.ToString()));

            enemyPlayer.UsedPokemon.Life -= damage;

            Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu o ataque {earth.ToString()} causou {damage} de dano, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");
        }
    }
}
