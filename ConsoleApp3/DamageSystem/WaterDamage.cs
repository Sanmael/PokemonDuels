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
    public class WaterDamage : IPokemonSystem
    {
        
        public long DealDamage(int hability)
        {           
            WaterSkill water  = (WaterSkill)hability;

            WaterSkillDamage waterSkillDamage = GeralServices.GetEnumValue<WaterSkillDamage>(water.ToString());

            return ((long)waterSkillDamage);
        }
    }
}
