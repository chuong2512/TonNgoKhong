using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Test : MonoBehaviour
    {
        private PowerPoleAttribute _poleAttribute = new();

        private readonly List<IUpgradeSkill> _upgradeSkillsLevel1 = new()
        {
            new AmountUpgrade(2),
            new AddDamageUpgrade(10),
            new AddRateDamageUpgrade(),
        };
        
        private readonly List<IUpgradeSkill> _upgradeSkillsLevel2 = new()
        {
            new AmountUpgrade(2),
            new AddDamageUpgrade(10),
            new AddRateDamageUpgrade(),
        };

        [ContextMenu("test")]
        private void test()
        {
            foreach (var upgradeSkill in _upgradeSkillsLevel1)
            {
                upgradeSkill.Upgrade(_poleAttribute);
            }
            Debug.Log(_poleAttribute.Amount);
            Debug.Log(_poleAttribute.Damage);
        }
    }
}