using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    public class Test : MonoBehaviour
    {
        private PowerPoleAttribute _poleAttribute = new();

        private readonly List<IUpgradeSkill> _upgradeSkills = new()
        {
            new AmountUpgrade(2),
            new AddDamageUpgrade(10),
            new AddRateDamageUpgrade(),
        };

        [ContextMenu("test")]
        private void test()
        {
            foreach (var upgradeSkill in _upgradeSkills)
            {
                upgradeSkill.Upgrade(_poleAttribute);
            }
            Debug.Log(_poleAttribute.Amount);
            Debug.Log(_poleAttribute.Damage);
        }
    }
}