using System;
using SinhTon;

public class SGameManager : PersistentSingleton<SGameManager>
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
        SetFirstScreen();
    }

    private void BindData()
    {
        _gameData = GameDataManager.Instance;
        _uiManager = ScreenManager.Instance;
    }

    private void SetFirstScreen()
    {
        _uiManager.OpenScreen(ScreenType.HomeScreen);
    }
}