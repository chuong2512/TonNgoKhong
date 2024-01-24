using UnityEngine.UI;

namespace Game
{
    public class EquipmentItem : EquipmentIcon
    {
        public Button itemBtn;

        private void Start()
        {
            itemBtn.onClick.AddListener(OnClickItem);
        }

        private void OnClickItem()
        {
            if (_eData != null)
            {
                ScreenManager.Instance.OpenScreen(ScreenType.EquipmentInfo, _eData);
            }
        }
    }
}