using System;
using Game;
using SinhTon;

public class OutGameAction
{
    public static Action<int> OnChangeGem;
    public static Action<int> OnChangeCoin;
    public static Action<int> OnChangeExp;
    public static Action<float> SetRegisterTime;

    public static Action<int> OnChooseMap;
}

public class OutGameManager : Singleton<OutGameManager>
{
    private GameDataManager _gameData;
    private ScreenManager _uiManager;

    public static Action<int> OnChangeGem;
    public static Action<int> OnChangeCoin;
    public static Action<int> OnChangeExp;
    public static Action<float> SetRegisterTime;

    public static Action<int> OnChooseMap;

    private void Start()
    {
        BindData();
    }

    private void BindData()
    {
        _gameData = GameDataManager.Instance;
        _uiManager = ScreenManager.Instance;
    }
}