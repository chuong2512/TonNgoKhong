using System;
using System.Collections.Generic;
using Game;
using UnityEngine;

namespace Game
{
    public abstract class SkillContainer<T> : MonoBehaviour where T : BaseSkill
    {
        [SerializeField] private T[] skills;
        private readonly Dictionary<int, T> _skillDict = new();

        private void OnValidate()
        {
            skills = GetComponentsInChildren<T>();
        }

        private void Awake()
        {
            foreach (var skill in skills)
            {
                _skillDict[skill.HashID] = skill;
                skill.gameObject.SetActive(false);
            }
        }

        public T GetSkill(int hashID)
        {
            _skillDict[hashID].gameObject.SetActive(true);
            return _skillDict[hashID];
        }
    }
}