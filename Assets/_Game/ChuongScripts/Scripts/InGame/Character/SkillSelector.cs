using System;
using System.Collections.Generic;
using System.Linq;
using Game;
using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public class SkillConstant
    {
        public const int MaxAmountWeapons = 6;
        public const int MaxLevelWeapon = 5;
        public const int MaxAmountSupplies = 6;
        public const int MaxLevelSupplies = 5;
    }

    public class SkillSelector : Singleton<SkillSelector>
    {
        private readonly Dictionary<int, int> _skillLevelDict = new();

        private WeaponType[] _availableWeapons;
        private SuppliesType[] _availableSupplies;

        private void Start()
        {
            HashIDSkill.InitData();
            LevelSkillConstant.InitData();
            InitData();
            GetBaseSkillPlayer();
        }

        private void InitData()
        {
            HashIDSkill.GetSkillTypeValues(out _availableWeapons);
            HashIDSkill.GetSkillTypeValues(out _availableSupplies);
        }

#if UNITY_EDITOR

        [Button]
        private void UpgradeSupplies(SuppliesType suppliesType)
        {
            UpgradeSkill(suppliesType);
        }

        [Button]
        private void UpgradeSupplies(WeaponType weaponType)
        {
            UpgradeSkill(weaponType);
        }
#endif

        private void GetBaseSkillPlayer()
        {
            UpgradeSkill(WeaponType.PowerPole);
            UpgradeSkill(SuppliesType.UpgradeMagnet);
        }

        public List<int> GetListSkillUpgrade(int amount = 3)
        {
            var listSkillUpgrade = new List<Enum>();
            var listWeaponAvailableUpgrade = GetListUpgradeAvailable(_availableWeapons,
                SkillConstant.MaxLevelWeapon, SkillConstant.MaxAmountWeapons);
            var listSuppliesAvailableUpgrade = GetListUpgradeAvailable(_availableSupplies,
                SkillConstant.MaxLevelSupplies, SkillConstant.MaxLevelSupplies);
            var weaponAvailableCount = listWeaponAvailableUpgrade.Count;
            var suppliesAvailableCount = listSuppliesAvailableUpgrade.Count;
            if (weaponAvailableCount + suppliesAvailableCount <= amount)
            {
                listSkillUpgrade = listSuppliesAvailableUpgrade;
                listSkillUpgrade.AddRange(listWeaponAvailableUpgrade);
                return listSkillUpgrade.Select(skill => skill.GetHashID()).ToList();
            }

            var weaponUpgradeAmount = Random.Range(0, 100f) switch
            {
                <= 15f => Mathf.Max(0, amount - 2),
                <= 40f => Mathf.Max(0, amount - 1),
                _ => amount
            };
            if (weaponAvailableCount < weaponUpgradeAmount)
            {
                listSkillUpgrade.AddRange(listWeaponAvailableUpgrade);
                listSkillUpgrade.AddRange(GetRandomSkill(listSuppliesAvailableUpgrade,
                    amount - weaponAvailableCount));
                return listSkillUpgrade.Select(skill => skill.GetHashID()).ToList();
            }

            var suppliesUpgradeAmount = Mathf.Min(amount - weaponUpgradeAmount, suppliesAvailableCount);
            weaponUpgradeAmount = amount - suppliesUpgradeAmount;
            listSkillUpgrade.AddRange(GetRandomSkill(listWeaponAvailableUpgrade, weaponUpgradeAmount));
            listSkillUpgrade.AddRange(GetRandomSkill(listSuppliesAvailableUpgrade, suppliesUpgradeAmount));
            return listSkillUpgrade.Select(skill => skill.GetHashID()).ToList();
        }

        private List<Enum> GetListUpgradeAvailable<T>(T[] availableSkill, int maxLevel, int maxSkillContain)
            where T : Enum
        {
            var availableUpgrade = new List<Enum>();
            var nonActiveSkill = new List<Enum>();
            var countSkillContain = 0;
            foreach (var skillType in availableSkill)
            {
                var hashID = skillType.GetHashID();
                //check weapon is not used by player
                if (!_skillLevelDict.ContainsKey(hashID))
                {
                    nonActiveSkill.Add(skillType);
                    continue;
                }

                countSkillContain++;
                //check weapon is max level, can not upgrade
                if (_skillLevelDict[hashID] >= maxLevel) continue;
                availableUpgrade.Add(skillType);
            }

            var skillAmountRemain = maxSkillContain - availableUpgrade.Count;
            if (skillAmountRemain <= 0)
            {
                return availableUpgrade;
            }

            availableUpgrade.AddRange(GetRandomSkill(nonActiveSkill, skillAmountRemain));
            return availableUpgrade;
        }

        private List<Enum> GetRandomSkill(List<Enum> skills, int listCount = 3)
        {
            if (listCount <= 0) return new List<Enum>();
            if (skills.Count <= listCount) return skills;
            var listSkillUpgrade = new List<Enum>();
            for (var count = 0; count < listCount; count++)
            {
                var index = Random.Range(0, skills.Count);
                var weapon = skills[index];
                listSkillUpgrade.Add(weapon);
                skills.RemoveAt(index);
            }

            return listSkillUpgrade;
        }


        public void UpgradeSkill<T>(T skillType) where T : Enum
        {
            UpgradeSkill(skillType.GetHashID());
        }

        public void UpgradeSkill(int hashIDSkill)
        {
            if (_skillLevelDict.ContainsKey(hashIDSkill))
            {
                _skillLevelDict[hashIDSkill]++;
            }
            else
            {
                _skillLevelDict[hashIDSkill] = 1;
            }

            if (IsSuppliesHashID(hashIDSkill))
            {
                PlayerManager.Instance.UpgradeSuppliesSkill(hashIDSkill);
            }
            else if (IsWeaponHashID(hashIDSkill))
            {
                PlayerManager.Instance.UpgradeWeaponSkill(hashIDSkill);
            }
        }

        public List<int> GetAllCurrentSkillID<T>(T[] availableSkill) where T : Enum
        {
            var result = new List<int>();
            var applySkillAmount = 0;

            //Add apply skill except max level skill
            foreach (var skillType in availableSkill)
            {
                var hashID = skillType.GetHashID();
                //check weapon is used by player
                if (!_skillLevelDict.ContainsKey(hashID)) continue;
                result.Add(hashID);
            }

            return result;
        }

        public List<int> GetAllCurrentSuppliesID()
        {
            return GetAllCurrentSkillID<SuppliesType>(_availableSupplies);
        }

        public List<int> GetAllCurrentWeaponsID()
        {
            return GetAllCurrentSkillID<WeaponType>(_availableWeapons);
        }

        public List<T> GetAllCurrentSkill<T>(T[] availableSkill) where T : Enum
        {
            var result = new List<T>();
            var applySkillAmount = 0;

            //Add apply skill except max level skill
            foreach (var skillType in availableSkill)
            {
                var hashID = skillType.GetHashID();
                //check weapon is used by player
                if (!_skillLevelDict.ContainsKey(hashID)) continue;

                result.Add(skillType);
            }

            return result;
        }

        public List<SuppliesType> GetAllCurrentSupplies()
        {
            return GetAllCurrentSkill<SuppliesType>(_availableSupplies);
        }

        public List<WeaponType> GetAllCurrentWeapons()
        {
            return GetAllCurrentSkill<WeaponType>(_availableWeapons);
        }

        public int GetSkillLevel(int hashID)
        {
            return _skillLevelDict.TryGetValue(hashID, out var level) ? level : 0;
        }

        public bool IsMaxLevel(int hashID)
        {
            var level = GetSkillLevel(hashID);

            return level >= hashID.GetMaxLevel();
        }

        public static bool IsWeaponHashID(int id) => typeof(WeaponType).ContainHashID(id);
        public static bool IsSuppliesHashID(int id) => typeof(SuppliesType).ContainHashID(id);
    }
}