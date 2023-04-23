using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
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
            long damageCaused = 0;

            EarthSkill earth = (EarthSkill)hability;

            switch (earth)
            {
                case EarthSkill.Terremoto:
                    damageCaused = 30;
                    break;
                case EarthSkill.Avalanche:
                    damageCaused = 40;
                    break;
                case EarthSkill.LamaToxica:
                    damageCaused = 20;
                    break;
                default:
                    damageCaused = 15;
                    break;
            }
            return damageCaused;
        }
        public List<string> ReceiveSkill()
        {
            return GetEnumValues<EarthSkill>().ToList();
        }
        public static string[] GetEnumValues<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }
    }
}
