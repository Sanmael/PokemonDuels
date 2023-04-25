using ConsoleApp3.Entities;
using System.Collections.Generic;

namespace ConsoleApp3.Interfaces
{
    public interface IPokemonSystem
    {
        public void DealDamage(int hability, Player usedPlayer, Player enemyPlayer);
    }
}
