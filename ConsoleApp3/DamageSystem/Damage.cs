using ConsoleApp3.Entities;
using System;


namespace ConsoleApp3.DamageSystem
{
    public class Damage : DamageCalculator
    {
        public void DealDamage(Habilidades hability, Player usedPlayer, Player enemyPlayer)
        {
            long damageInflicted = DamageInflicted(hability, usedPlayer.UsedPokemon, enemyPlayer.UsedPokemon);

            string damageMessage = damageInflicted == 0 ? null : damageInflicted > 0 ?
                  $"O dano foi Super Eficiente pois seu Pokemon é do tipo {usedPlayer.UsedPokemon.Type.ToString()}" :
                  $"O dano não foi eficiente pois seu Pokemon é do tipo {usedPlayer.UsedPokemon.Type.ToString()}";

            damageInflicted += hability.Damage;

            enemyPlayer.UsedPokemon.Life -= damageInflicted;

            Console.WriteLine($"\n{enemyPlayer.UsedPokemon.Name} recebeu o ataque {hability.Name} causou {damageInflicted} {damageMessage}, sua vida atual é : {enemyPlayer.UsedPokemon.Life}");
        }
    }
}
