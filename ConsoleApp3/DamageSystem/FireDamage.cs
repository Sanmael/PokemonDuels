using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DamageSystem
{
    public class FireDamage : IPokemonSystem
    {
        public long DealDamage(int hability)
        {
            FireSkill fire = (FireSkill)hability;
            
            FireSkillDamage fireSkillDamage = GeralServices.GetEnumValue<FireSkillDamage>(fire.ToString());

            return ((long)fireSkillDamage);            
        }
    }
}

