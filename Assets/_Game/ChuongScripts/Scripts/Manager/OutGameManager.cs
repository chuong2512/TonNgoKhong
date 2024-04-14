using System;
using Game;
using SinhTon;

public class OutGameAction
{
    public static Action<int> OnChangeGem;
    public static Action<int> OnChangeCoin;
    public static Action<int> OnChangeExp;
    public static Action<float> SetRegisterTime;
    public static Action ChangeEquipment;
    public static Action UpgradeEvolve;

    public static Action<int> OnChooseMap;
}

public class OutGameManager : Singleton<OutGameManager>
{
    private GameDataManager _gameData => GameDataManager.Instance;
    private ScreenManager _uiManager => ScreenManager.Instance;
}