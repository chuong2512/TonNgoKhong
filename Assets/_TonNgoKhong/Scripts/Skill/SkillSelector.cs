using System;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Skill
{
    public class SkillSelector : Singleton<SkillSelector>
    {
        public const int MaxAmountWeapon = 6;
        public const int MaxLevelWeapon = 5;
        public const int MaxAmountSupplies = 6;
        public const int MaxLevelSupplies = 5;
        private readonly Dictionary<int, int> _skillLevelDict = new();
        private WeaponType[] _availableWeapons;
        private SuppliesType[] _availableSupplies;

        private void Start()
        {
            InitData();
            GetBaseSkillPlayer();
        }
#if UNITY_EDITOR
        [ContextMenu("test")]
        private void TestList()
        {
            var testList = GetListSkillUpgrade();
            foreach (var test in testList)
            {
                Debug.Log($"{test} a.k.a {HashIDSkill.Instance[test]} to select");
            }
        }
#endif
        private void InitData()
        {
            HashIDSkill.Instance.GetSkillTypeValues(out _availableWeapons);
            HashIDSkill.Instance.GetSkillTypeValues(out _availableSupplies);
        }
        
        private void GetBaseSkillPlayer(){}

        public List<int> GetListSkillUpgrade(int amount = 3)
        {
            var maxWeaponUpgradeAmount = Random.Range(0, 100f) switch
            {
                <= 15f => 1,
                <= 40f => 2,
                _ => amount
            };
            var listWeaponUpgrade = GetListUpgrade(_availableWeapons, maxWeaponUpgradeAmount, 
                MaxAmountWeapon, MaxLevelWeapon);
            var maxSuppliesUpgradeAmount = amount - listWeaponUpgrade.Count;
            var listSuppliesUpgrade = GetListUpgrade(_availableSupplies, maxSuppliesUpgradeAmount,
                MaxAmountSupplies, MaxLevelSupplies);
            var listSkillUpgrade = new List<int>();
            foreach (var weaponType in listWeaponUpgrade)
            {
                listSkillUpgrade.Add(HashIDSkill.Instance.GetHashID(weaponType));
            }
            foreach (var suppliesType in listSuppliesUpgrade)
            {
                listSkillUpgrade.Add(HashIDSkill.Instance.GetHashID(suppliesType));
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
                var hashID = HashIDSkill.Instance.GetHashID(skillType);
                if(maxListCount <= 0) break;
                //check weapon is used by player
                if (!_skillLevelDict.ContainsKey(hashID)) continue;
                //check weapon is max level, can not upgrade
                applySkillAmount++;
                if(_skillLevelDict[hashID] > maxLevel) continue;
                availableUpgrade.Add(skillType);
                maxListCount--;

            }
            
            //add non-apply skill in player
            var skillCanUpgradeAmount = maxSkillAmount - applySkillAmount;
            foreach (var weapon in availableSkill)
            {
                if(maxListCount <= 0) break;
                if(skillCanUpgradeAmount <= 0) break;
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
            UpgradeSkill(HashIDSkill.Instance.GetHashID(skillType));
        }

        public void UpgradeSkill(int hashIDSkill)
        {
            _skillLevelDict[hashIDSkill]++;
        }
    }
}