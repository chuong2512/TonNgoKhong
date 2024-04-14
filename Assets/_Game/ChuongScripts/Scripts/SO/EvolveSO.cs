using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    [CreateAssetMenu(fileName = "EvolveSO", menuName = "ScriptableObjects/EvolveSO", order = 1)]
    public class EvolveSO : ScriptableObject
    {
        public EvolveStatLevel[] levels;

        //data
        public EvolveStatVisual[] statVisuals;

        public EvolveStatVisual GetEvolveStat(int levelIndex)
        {
            var level = levels[levelIndex];
            return statVisuals[level.ID];
        }

        [Button]
        public void SetData()
        {
            for (int i = 0; i < levels.Length; i++)
            {
                var id = i % 3;

                IUpgradeSkill info = null;
                int value = 0;

                switch (id)
                {
                    case 0:
                        value = i * 1 + 2;
                        info = new AddDamageUpgrade(value);
                        break;
                    case 1:
                        value = i * 2 + 6;
                        info = new HPUpgrade(value);
                        break;
                    case 2:

                        value = i * 1 + 2;
                        info = new IDefenseUpgrade(value);
                        break;
                }


                levels[i] = new EvolveStatLevel
                {
                    upgradeInfo = info,
                    ID = i % 3,
                    price = new GameResource()
                    {
                        Type = ResourceType.Coin,
                        Value = (i + 1) * 150
                    },
                    value = value
                };
            }
        }
    }

    [Serializable]
    public class EvolveStatLevel
    {
        public int ID;
        [SerializeReference, SubclassSelector] public IUpgradeSkill upgradeInfo;
        public float value;
        public GameResource price;
    }

    [Serializable]
    public class EvolveStatVisual
    {
        public Sprite icon;
        public string name;
    }
}