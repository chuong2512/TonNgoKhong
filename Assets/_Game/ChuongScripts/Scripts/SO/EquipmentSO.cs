using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game
{
    public class EquipmentConstant
    {
        public const int MaxLevel = 10;
        public const int MaxRank = 10;
    }

    [CreateAssetMenu(fileName = "EquipmentSO", menuName = "ScriptableObjects/EquipmentSO", order = 1)]
    public class EquipmentSO : ScriptableObject
    {
        [Header("Equipment Info")] [SerializeReference, SubclassSelector]
        public List<EquipmentData> EquipmentDatas;

        [Header("RankInfo")] public List<RankInfo> RankInfos;

        public EquipmentData GetEquipmentData(int ID)
        {
            return EquipmentDatas.Find(data => data.ID == ID);
        }

        private void OnValidate()
        {
            for (int i = 0; i < EquipmentDatas.Count; i++)
            {
                if (EquipmentDatas[i] != null)
                {
                    EquipmentDatas[i].ID = i;
                }
            }
        }

        [Button]
        public void SetData(int ID, float baseData)
        {
            var e = GetEquipmentData(ID);

            e.InitData(baseData);
        }

        public List<IEquipmentUpgrade> GetListUpgradeSkill(int ID, int level, int rank)
        {
            var eData = GetEquipmentData(ID);

            if (eData != null)
            {
                var skillUpgrade = eData.equipmentUpgradeInfos[level].SkillUpgradeInfo;

                for (int i = 0; i < skillUpgrade.Count; i++)
                {
                    skillUpgrade[i].Multipler = RankInfos[rank].multipler;
                }

                return skillUpgrade;
            }

            return null;
        }

        public List<IEquipmentUpgrade> GetListUpgradeSkill(IEquipment equipment)
        {
            return GetListUpgradeSkill(equipment.ID, equipment.Level, equipment.Rank);
        }

        public List<EquipmentData> NeckDatas => EquipmentDatas.FindAll(data => data is NeckData);
        public List<EquipmentData> ArmorDatas => EquipmentDatas.FindAll(data => data is ArmorData);
        public List<EquipmentData> GloveDatas => EquipmentDatas.FindAll(data => data is GloveData);
        public List<EquipmentData> RingDatas => EquipmentDatas.FindAll(data => data is RingData);
        public List<EquipmentData> ShoeDatas => EquipmentDatas.FindAll(data => data is ShoeData);
    }

    [Serializable]
    public abstract class EquipmentData
    {
        public int ID;
        public string name;
        public Sprite icon;

        [HideInInspector] public int MaxRank = 9;
        public int MaxLevel => equipmentUpgradeInfos != null ? equipmentUpgradeInfos.Count - 1 : 0;

        [FormerlySerializedAs("ListUpgradeSkill")]
        public List<EquipmentUpgradeInfo> equipmentUpgradeInfos;

        public abstract AEquipment CreateEquipment();

        public abstract void InitData(float baseData);
    }

    [Serializable]
    public class NeckData : EquipmentData
    {
        public override AEquipment CreateEquipment()
        {
            return new Necklace()
            {
                ID = ID,
                Level = 0
            };
        }

        public override void InitData(float baseData)
        {
            equipmentUpgradeInfos = new List<EquipmentUpgradeInfo>();

            for (int i = 0; i < EquipmentConstant.MaxLevel; i++)
            {
                equipmentUpgradeInfos.Add(new EquipmentUpgradeInfo()
                {
                    SkillUpgradeInfo = new List<IEquipmentUpgrade>() {new DamageEquipment((i + 1) * baseData)},
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = i * 100 + 100
                    }
                });
            }
        }
    }

    [Serializable]
    public class ArmorData : EquipmentData
    {
        public override AEquipment CreateEquipment()
        {
            return new Armor()
            {
                ID = ID,
                Level = 0
            };
        }

        public override void InitData(float baseData)
        {
            equipmentUpgradeInfos = new List<EquipmentUpgradeInfo>();

            for (int i = 0; i < EquipmentConstant.MaxLevel; i++)
            {
                equipmentUpgradeInfos.Add(new EquipmentUpgradeInfo()
                {
                    SkillUpgradeInfo = new List<IEquipmentUpgrade>() {new HPEquipment((i + 1) * baseData)},
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = i * 100 + 100
                    }
                });
            }
        }
    }

    [Serializable]
    public class GloveData : EquipmentData
    {
        public override AEquipment CreateEquipment()
        {
            return new Glove()
            {
                ID = ID,
                Level = 0
            };
        }

        public override void InitData(float baseData)
        {
            equipmentUpgradeInfos = new List<EquipmentUpgradeInfo>();

            for (int i = 0; i < EquipmentConstant.MaxLevel; i++)
            {
                equipmentUpgradeInfos.Add(new EquipmentUpgradeInfo()
                {
                    SkillUpgradeInfo = new List<IEquipmentUpgrade>() {new DamageEquipment((i + 1) * baseData)},
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = i * 100 + 100
                    }
                });
            }
        }
    }

    [Serializable]
    public class ShoeData : EquipmentData
    {
        public override AEquipment CreateEquipment()
        {
            return new Shoe()
            {
                ID = ID,
                Level = 0
            };
        }

        public override void InitData(float baseData)
        {
            equipmentUpgradeInfos = new List<EquipmentUpgradeInfo>();

            for (int i = 0; i < EquipmentConstant.MaxLevel; i++)
            {
                equipmentUpgradeInfos.Add(new EquipmentUpgradeInfo()
                {
                    SkillUpgradeInfo = new List<IEquipmentUpgrade>() {new HPEquipment((i + 1) * baseData)},
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = i * 100 + 100
                    }
                });
            }
        }
    }

    [Serializable]
    public class RingData : EquipmentData
    {
        public override AEquipment CreateEquipment()
        {
            return new Ring()
            {
                ID = ID,
                Level = 0
            };
        }

        public override void InitData(float baseData)
        {
            equipmentUpgradeInfos = new List<EquipmentUpgradeInfo>();

            for (int i = 0; i < EquipmentConstant.MaxLevel; i++)
            {
                equipmentUpgradeInfos.Add(new EquipmentUpgradeInfo()
                {
                    SkillUpgradeInfo = new List<IEquipmentUpgrade>() {new DamageEquipment((i + 1) * baseData)},
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = i * 100 + 100
                    }
                });
            }
        }
    }

    [Serializable]
    public class EquipmentUpgradeInfo
    {
        [SerializeReference, SubclassSelector] public List<IEquipmentUpgrade> SkillUpgradeInfo;
        public GameResource price;
    }

    [Serializable]
    public struct GameResource
    {
        public ResourceType Type;
        public int Value;
    }

    public enum ResourceType
    {
        Coin,
        Gem
    }

    [Serializable]
    public class RankInfo
    {
        public float multipler;
    }
}