using _TonNgoKhong;
using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;

public class Constant
{
    public static string DataKey_PlayerData = "player_data";
    public static string DataKey_SettingData = "setting_data";
}


[DefaultExecutionOrder(-100)]
public class GameDataManager : PersistentSingleton<GameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/
    [InlineEditor()] public LevelSO LevelSo;
    [InlineEditor()] public SkillSO SkillSo;

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [HideInInspector] public PlayerData playerData;
    [HideInInspector] public SettingData settingData;

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
    }

    private void Start()
    {
        Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
    }

    public void ResetData()
    {
        playerData.ResetData();
    }
}