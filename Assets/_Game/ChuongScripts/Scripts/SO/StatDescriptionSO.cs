using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game
{
    [CreateAssetMenu(fileName = "StatDescriptionSO", menuName = "ScriptableObjects/StatDescriptionSO", order = 1)]
    public class StatDescriptionSO : ScriptableObject
    {
        public PlayerStatus BaseStat => new PlayerStatus(80, 1, 3);

        public List<EquipmentType> EquipmentTypes;

        public Sprite GetTypeImg(EquipmentData equipmentData)
        {
            var find = EquipmentTypes.Find(e => e.EquipmentData.GetType() == equipmentData.GetType());

            if (find != null)
            {
                return find.TypeImg;
            }

            return null;
        }
    }

    [Serializable]
    public class EquipmentType
    {
        [SerializeReference, SubclassSelector] public EquipmentData EquipmentData;
        public Sprite TypeImg;
    }
}