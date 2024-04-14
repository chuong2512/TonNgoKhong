using UnityEngine.Serialization;

namespace Game
{
    using SinhTon;
    using Sirenix.OdinInspector;
    using UnityEngine;

    public class Constant
    {
        public static string DataKey_PlayerData = "player_data";
        public static string DataKey_SettingData = "setting_data";
        public static string DataKey_InventoryData = "inventory_data";
        public static string DataKey_EvolveData = "evolve_data";
    }


    [DefaultExecutionOrder(-100)]
    public partial class GameDataManager : PersistentSingleton<GameDataManager>
    {
        /*----Scriptable data-----------------------------------------------------------------------------------------------*/
        [InlineEditor()] public LevelSO LevelSo;
        [InlineEditor()] public SkillSO SkillSo;
        [InlineEditor()] public StatDescriptionSO StatDescriptionSO;
        [InlineEditor()] public EquipmentSO EquipmentSO;
        [InlineEditor()] public RankBGSO RankBGSO;
        [InlineEditor()] public EvolveSO EvolveSo;

        /*----Data variable-------------------------------------------------------------------------------------------------*/
        [HideInInspector] public PlayerData playerData;
        [HideInInspector] public SettingData settingData;
        [HideInInspector] public InventoryData inventoryData;
        [HideInInspector] public EvolveData evolveData;

        private void OnEnable()
        {
            playerData = new GameObject(Constant.DataKey_PlayerData).AddComponent<PlayerData>();
            playerData.transform.parent = transform;
            playerData.Init();
            playerData.ValidateData();

            settingData = new GameObject(Constant.DataKey_SettingData).AddComponent<SettingData>();
            settingData.transform.parent = transform;
            settingData.Init();
            settingData.ValidateData();

            inventoryData = new GameObject(Constant.DataKey_InventoryData).AddComponent<InventoryData>();
            inventoryData.transform.parent = transform;
            inventoryData.Init();
            inventoryData.ValidateData();

            evolveData = new GameObject(Constant.DataKey_EvolveData).AddComponent<EvolveData>();
            evolveData.transform.parent = transform;
            evolveData.Init();
            evolveData.ValidateData();


            HashIDSkill.InitData();
            LevelSkillConstant.InitData();
        }

        private void Start()
        {
            Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
        }

        public void ResetData()
        {
            playerData.ResetData();
        }

        public int GetLevel(out float f)
        {
            return LevelSo.GetLevel(playerData.Exp, out f);
        }

        public DataMap GetCurrentDataMap()
        {
            return LevelSo.GetMapItem(playerData.choosingMap).dataMap;
        }

        public bool IsMaxLevel()
        {
            return playerData.choosingMap + 1 >= LevelSo.CountMap;
        }
    }
}