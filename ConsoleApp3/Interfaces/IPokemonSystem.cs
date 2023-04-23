using System.Collections.Generic;

namespace ConsoleApp3.Interfaces
{
    public interface IPokemonSystem
    {
        public List<string> ReceiveSkill();
        public long DealDamage(int hability);
    }
}
