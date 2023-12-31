using _TonNgoKhong;
using SinhTon;
using Sirenix.OdinInspector;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameDataManager : PersistentSingleton<GameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/
    [InlineEditor()] public LevelSO LevelSo;
    [InlineEditor()] public SkillSO SkillSo;

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [HideInInspector] public PlayerData playerData;

    private void OnEnable()
    {
        playerData = new GameObject(Constant.DataKey_PlayerData).AddComponent<PlayerData>();
        playerData.transform.parent = transform;
        playerData.Init();
        playerData.ValidateData();
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