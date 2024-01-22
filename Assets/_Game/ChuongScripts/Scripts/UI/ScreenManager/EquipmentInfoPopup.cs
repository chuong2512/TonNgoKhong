using Jackal;
using SinhTon.Scripts.UI;
using UnityEngine;

namespace Game
{
    public class EquipmentInfoPopup : BaseScreenWithModel<EScrollData>
    {
        private EScrollData _eData;
        
        public override void BindData(EScrollData data)
        {
            _eData = data;
        }

        public override ScreenType GetID() => ScreenType.EquipmentInfo;
    }
}