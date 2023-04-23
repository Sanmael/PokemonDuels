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

            long damageCaused = 0;
            
            switch (fire)
            {
                case FireSkill.BolaDeFogo:
                    damageCaused = 30;
                    break;
                case FireSkill.LancaChamas:
                    damageCaused = 40;
                    break;
                case FireSkill.CaudaDeFogo:
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
            return GetEnumValues<FireSkill>().ToList();            
        }
        public static string[] GetEnumValues<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }
    }
}

