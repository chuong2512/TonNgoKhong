using UnityEngine;

namespace Game
{
    public partial class GameManager
    {
        public PlayerStatus GetPlayerStatus()
        {
            var status = _gameData.StatDescriptionSO.BaseStat;

            //equipment
            var armorID = _gameData.CurrentArmor;
            var ringID = _gameData.CurrentRing;
            var shoeID = _gameData.CurrentShoe;
            var necklaceID = _gameData.CurrentNecklace;
            var gloveID = _gameData.CurrentGlove;

            var armorData = _gameData.GetItemWithMapID(armorID);
            UpgradeStatusWithID(armorData, status);
            var ringData = _gameData.GetItemWithMapID(ringID);
            UpgradeStatusWithID(ringData, status);
            var shoeData = _gameData.GetItemWithMapID(shoeID);
            UpgradeStatusWithID(shoeData, status);
            var gloveData = _gameData.GetItemWithMapID(gloveID);
            UpgradeStatusWithID(gloveData, status);
            var necklaceData = _gameData.GetItemWithMapID(necklaceID);
            UpgradeStatusWithID(necklaceData, status);

            return status;
        }

        public void UpgradeStatusWithID(IEquipment equipment, PlayerStatus status)
        {
            if (equipment == null) return;
            var listUpgradeSkill = _gameData.EquipmentSO.GetListUpgradeSkill(equipment);

            foreach (var skill in listUpgradeSkill)
            {
                skill.Upgrade(status);
            }
        }
    }
}