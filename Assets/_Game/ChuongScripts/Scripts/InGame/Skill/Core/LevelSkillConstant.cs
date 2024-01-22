using System;
using System.Collections.Generic;

namespace Game
{
    public static class LevelSkillConstant
    {
        public static readonly Dictionary<int, int> MaxLevelDict = new Dictionary<int, int>();

        public static void InitData()
        {
            Init<WeaponType>(6);
            Init<SuppliesType>(6);
        }
        
        private static void Init<T>(int maxLevel) where T : Enum
        {
            HashIDSkill.GetSkillTypeValues<T>(out var values);
            foreach (var value in values)
            {
                MaxLevelDict[value.GetHashID()] = maxLevel;
            }
        }

        public static int GetMaxLevel(this int hashID) => MaxLevelDict[hashID];
    }
}