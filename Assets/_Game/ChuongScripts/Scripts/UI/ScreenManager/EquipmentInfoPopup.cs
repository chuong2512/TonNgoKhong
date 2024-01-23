using System;
using Game;
using SinhTon.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentInfoPopup : BaseScreenWithModel<EScrollData>
    {
        [Header("Button")]  public Button upgradeBtn;
        public Button equipBtn;
        public Button removeBtn;

        [Header("Info")] public TextMeshProUGUI nameTMP;
        public EquipmentStat equipmentStat;

        private EScrollData _eData;

        public override void BindData(EScrollData data)
        {
            _eData = data;
        }

        public override ScreenType GetID() => ScreenType.EquipmentInfo;
    }
}