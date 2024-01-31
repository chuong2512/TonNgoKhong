using EnhancedUI.EnhancedScroller;
using TMPro;
using UnityEngine;

namespace Game
{
    public class CurrentEquipment : MonoBehaviour
    {
        private GameDataManager _dataManager => GameDataManager.Instance;

        public TextMeshProUGUI hpTMP, atkTMP;
        public EquipmentItem neck, glove, ring, shoe, armor;

        public void BindData()
        {
            if (_dataManager.CurrentNecklace >= 0)
                neck.SetData(new EScrollData(_dataManager.CurrentNecklace));
            else
                neck.SetNone(new NeckData());

            if (_dataManager.CurrentGlove >= 0)
                glove.SetData(new EScrollData(_dataManager.CurrentGlove));
            else
                glove.SetNone(new GloveData());

            if (_dataManager.CurrentRing >= 0)
                ring.SetData(new EScrollData(_dataManager.CurrentRing));
            else
                ring.SetNone(new RingData());

            if (_dataManager.CurrentShoe >= 0)
                shoe.SetData(new EScrollData(_dataManager.CurrentShoe));
            else
                shoe.SetNone(new ShoeData());

            if (_dataManager.CurrentArmor >= 0)
                armor.SetData(new EScrollData(_dataManager.CurrentArmor));
            else
                armor.SetNone(new ArmorData());

            var playerStatus = GameManager.Instance.GetPlayerStatus();

            hpTMP.SetText($"{playerStatus.MaxHealth:F1}");
            atkTMP.SetText($"{playerStatus.Damage:F1}");
        }
    }
}