using System;
using SinhTon;

public class SGameManager : Singleton<SGameManager>
{
    private GameDataManager _gameData;
    private ScreenManager _uiManager;

    public static Action<int> OnChangeBullet;
    public static Action<int> OnChangeDiamond;
    public static Action<bool> OnPlayMusic;
    public static Action<int> OnChooseSong;
    public static Action<int> OnUnlockSong;
    public static Action<float> SetTimeStop;
    public static Action<float> SetRegisterTime;

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

        if (_gameData.playerData.time <= 0)
        {
            _uiManager.OpenScreen(ScreenType.RegisterScreen);
        }
        else if (!_gameData.playerData.IsRate)
        {
            _uiManager.OpenScreen(ScreenType.RateGame);
        }
    }
}