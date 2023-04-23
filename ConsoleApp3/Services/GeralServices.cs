using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    public static class GeralServices
    {
        public static string[] GetEnumValues<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }
        public static TEnum GetEnumValue<TEnum>(string value) where TEnum : Enum
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
        public static List<string> ReceiveSkill<TEnum>() where TEnum : Enum
        {
            return GetEnumValues<TEnum>().ToList();
        }
    }
}
