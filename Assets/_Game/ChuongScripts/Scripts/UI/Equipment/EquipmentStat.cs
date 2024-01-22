using TMPro;
using UnityEngine;

namespace Game
{
    public class EquipmentStat : MonoBehaviour
    {
        public TextMeshProUGUI statName;
        public TextMeshProUGUI statValue;

        public void SetStat(IEquipmentUpgrade upgrade)
        {
            statName.SetText(upgrade.StatName);
            statValue.SetText(upgrade.StatValue);
        }
    }
}