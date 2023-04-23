using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.DamageSystem
{
    public class PlantDamage : IPokemonSystem
    {
        public long DealDamage(int hability)
        {           
            PlantSkill plant = (PlantSkill)hability;

            PlantSkillDamage plantSkillDamage = GeralServices.GetEnumValue<PlantSkillDamage>(plant.ToString());

            return ((long)plantSkillDamage);
        }
    }
}
