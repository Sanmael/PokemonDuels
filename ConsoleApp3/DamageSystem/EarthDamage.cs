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
    public class EarthDamage : IPokemonSystem
    {
        public long DealDamage(int hability)
        {
            EarthSkill earth = (EarthSkill)hability;

            EarthSkillDamage earthSkillDamage = GeralServices.GetEnumValue<EarthSkillDamage>(earth.ToString());

            return ((long)earthSkillDamage);
        }
    }
}
