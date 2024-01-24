using SinhTon.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EquipmentInfoPopup : BaseScreenWithModel<EScrollData>
    {
        public EquipmentIcon Item;

        [Header("Button")] public Button upgradeBtn;
        public Button equipBtn;
        public Button removeBtn;

        [Header("Info")] public TextMeshProUGUI nameTMP;
        public TextMeshProUGUI priceTMP;
        public TextMeshProUGUI levelTMP;

        public EquipmentStat equipmentStat;

        private GameDataManager _dataManager => GameDataManager.Instance;

        private AEquipment _equipment;

        private void Start()
        {
            upgradeBtn.onClick.AddListener(OnClickUpgrade);
            equipBtn.onClick.AddListener(OnClickEquip);
            removeBtn.onClick.AddListener(OnClickRemove);
        }

        private void OnClickRemove()
        {
            if (_equipment is Necklace)
            {
                _dataManager.CurrentNecklace = -1;
            }

            if (_equipment is Glove)
            {
                _dataManager.CurrentGlove = -1;
            }

            if (_equipment is Shoe)
            {
                _dataManager.CurrentShoe = -1;
            }

            if (_equipment is Ring)
            {
                _dataManager.CurrentRing = -1;
            }

            if (_equipment is Armor)
            {
                _dataManager.CurrentArmor = -1;
            }

            OutGameAction.ChangeEquipment?.Invoke();
            Back();
        }

        private void OnClickEquip()
        {
            if (_equipment is Necklace)
            {
                _dataManager.CurrentNecklace = _equipment.MapID;
            }

            if (_equipment is Glove)
            {
                _dataManager.CurrentGlove = _equipment.MapID;
            }

            if (_equipment is Shoe)
            {
                _dataManager.CurrentShoe = _equipment.MapID;
            }

            if (_equipment is Ring)
            {
                _dataManager.CurrentRing = _equipment.MapID;
            }

            if (_equipment is Armor)
            {
                _dataManager.CurrentArmor = _equipment.MapID;
            }

            OutGameAction.ChangeEquipment?.Invoke();
            Back();
        }

        private void OnClickUpgrade()
        {
            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(_equipment.ID);

            if (_dataManager.playerData.Coin >= equipmentData.equipmentUpgradeInfos[_equipment.Level].price.Value)
            {
                if (_dataManager.UpgradeLevelEquipment(_equipment))
                {
                    _dataManager.playerData.Coin -= equipmentData.equipmentUpgradeInfos[_equipment.Level - 1].price.Value;
                    Refresh();
                }
                else
                {
                    ToastManager.Instance.ShowMessageToast("Nâng cấp tối đa!!!");
                }
            }
            else
            {
                ToastManager.Instance.ShowWarningToast("Không đủ ngân lượng!!!");
            }
        }

        public override void BindData(EScrollData data)
        {
            Item.SetData(data);

            _equipment = _dataManager.GetItemWithMapID(data.MapID);

            equipBtn.gameObject.SetActive(!_dataManager.IsUsingMapID(data.MapID));
            removeBtn.gameObject.SetActive(_dataManager.IsUsingMapID(data.MapID));

            Refresh();
        }

        private void Refresh()
        {
            var equipmentData = _dataManager.EquipmentSO.GetEquipmentData(_equipment.ID);
            var equipment = _dataManager.EquipmentSO.GetListUpgradeSkill(_equipment);
            nameTMP.SetText("Tên : " + (equipmentData.name));
            levelTMP.SetText("Cấp độ : " + (_equipment.Level + 1));
            priceTMP.SetText(
                "Nâng cấp : " + equipmentData.equipmentUpgradeInfos[_equipment.Level].price.Value + " <sprite=0>");
            equipmentStat.SetStat(equipment[0]);
        }

        public override ScreenType GetID() => ScreenType.EquipmentInfo;
    }
}