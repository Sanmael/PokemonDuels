using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DamageSystem
{
    public class WaterDamage : IPokemonSystem
    {
        
        public long DealDamage(int habilidade)
        {
            long damageCaused = 0;

            WaterSkill water  = (WaterSkill)habilidade;

            switch (water)
            {
                case WaterSkill.JatoDagua:
                    damageCaused = 30;
                    break;
                case WaterSkill.HidroBomba:
                    damageCaused = 40;
                    break;
                case WaterSkill.Mergulho:
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
            return GetEnumValues<WaterSkill>().ToList();
        }
        public static string[] GetEnumValues<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }
    }
}
