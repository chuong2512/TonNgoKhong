using System;
using System.Collections.Generic;
using Game;
using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Skill
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
        private void UpgradePowerPole()
        {
            UpgradeSkill(WeaponType.PowerPole);
        }

        [Button]
        private void UpgradeSupplies(SuppliesType suppliesType)
        {
            UpgradeSkill(suppliesType);
        }
#endif

        private void GetBaseSkillPlayer()
        {
            UpgradeSkill(WeaponType.PowerPole);
            UpgradeSkill(SuppliesType.UpgradeMagnet);
        }

        public List<int> GetListSkillUpgrade(int amount = 3)
        {
            var maxWeaponUpgradeAmount = Random.Range(0, 100f) switch
            {
                <= 15f => 1,
                <= 40f => 2,
                _ => amount
            };
            var listWeaponUpgrade = GetListUpgrade(_availableWeapons, maxWeaponUpgradeAmount,
                SkillConstant.MaxAmountWeapons, SkillConstant.MaxLevelWeapon);
            var maxSuppliesUpgradeAmount = amount - listWeaponUpgrade.Count;
            var listSuppliesUpgrade = GetListUpgrade(_availableSupplies, maxSuppliesUpgradeAmount,
                SkillConstant.MaxAmountSupplies, SkillConstant.MaxLevelSupplies);
            var listSkillUpgrade = new List<int>();
            foreach (var weaponType in listWeaponUpgrade)
            {
                listSkillUpgrade.Add(weaponType.GetHashID());
            }

            foreach (var suppliesType in listSuppliesUpgrade)
            {
                listSkillUpgrade.Add(suppliesType.GetHashID());
            }

            return listSkillUpgrade;
        }


        private List<T> GetListUpgrade<T>
            (T[] availableSkill, int maxListCount, int maxSkillAmount, int maxLevel) where T : Enum
        {
            if (maxListCount <= 0) return new List<T>();
            var availableUpgrade = new List<T>();
            var applySkillAmount = 0;

            //Add apply skill except max level skill
            foreach (var skillType in availableSkill)
            {
                var hashID = skillType.GetHashID();
                if (maxListCount <= 0) break;
                //check weapon is used by player
                if (!_skillLevelDict.ContainsKey(hashID)) continue;
                //check weapon is max level, can not upgrade
                applySkillAmount++;
                if (_skillLevelDict[hashID] > maxLevel) continue;
                availableUpgrade.Add(skillType);
                maxListCount--;
            }

            //add non-apply skill in player
            var skillCanUpgradeAmount = maxSkillAmount - applySkillAmount;
            foreach (var weapon in availableSkill)
            {
                if (maxListCount <= 0) break;
                if (skillCanUpgradeAmount <= 0) break;
                availableUpgrade.Add(weapon);
                skillCanUpgradeAmount--;
            }

            var availableAmount = Mathf.Min(availableUpgrade.Count, maxListCount);
            var listSkillUpgrade = new List<T>();
            for (int count = 0; count < availableAmount; count++)
            {
                var index = Random.Range(0, availableUpgrade.Count);
                var weapon = availableUpgrade[index];
                listSkillUpgrade.Add(weapon);
                availableUpgrade.RemoveAt(index);
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