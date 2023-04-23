using ConsoleApp3.AllEnum;
using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.DamageSystem
{
    public class PlantDamage : IPokemonSystem
    {
        public long DealDamage(int hability)
        {
            long damageCaused = 0;

            PlantSkill plant = (PlantSkill)hability;

            switch (plant)
            {
                case PlantSkill.ChicoteDeTrepadeira:
                    damageCaused = 30;
                    break;
                case PlantSkill.SementeSangueSuga:
                    damageCaused = 40;
                    break;
                case PlantSkill.RaizForte:
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
            return GetEnumValues<PlantSkill>().ToList();            
        }
        public static string[] GetEnumValues<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }
    }
}
